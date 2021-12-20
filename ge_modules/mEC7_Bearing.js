// import cEC7_Bearing_Capacity from 'cEC7_Bearing_Capacity'; 
//' ==========================================================================================
//' Design bearing resistances calculated from EC-7 EN 1997-1:2004
//'
//' Equation D.2 Drained conditions
//' Equation D.1 Undrained conditions
//' ==========================================================================================
//' Coded  | Simon Thomson
//' ==========================================================================================
//' Company | AECOM
//' ==========================================================================================
//' Date            |     Version   |         Description 
//' ==========================================================================================
//  April 2010      |    01.00.00   | Coded for Excel VBA addin             
//  Dec 2021        |    02.00.00   | Coded for Excel JavaScript addin           
//' ==========================================================================================

// export default

class cEC7_DrainedBearingResistanceD2 {
 
        constructor (data) {
        this._const_PI = 3.14159;
        this._Htheta_rad = this.const_PI / 2.00;
        
        if (data != null) {
            this._H = data.H
            this._Htheta_rad = data.Htheta_rad
            this._q = data.q
            this._B = data.B
            this._g = data.g
            this._phi_rad = data.phi_rad
            this._q = data.q
            this._c = data.c
            this._a = data.a
            this._L = data.L
            this._alpha_rad = data.alpha_rad
        }

            
    }
        references () {
            var dict = {
                id: 0,
                reference:"" 
             };
             dict[1] = {id: 1, reference: "Design bearing resistances calculated from EC-7 EN 1997-1:2004 Annex D"}
             
             return dict;

        }
        
        limitations () {
            var dict = {
                id: 0,
                reference:"" 
             };
             dict[1] = {id: 1,limitation: "Ultimate limit state ONLY"}

             return dict;
        }

        param_descriptions () {
        
            var dict = {
               param:"",
               description:""
            };

            dict["L"] = {param: "L", description: "Effective length of foundation"}
            dict["B"] = {param: "B", description: "Effective breadth of foundation"}
            dict["a"] = {param: "a", description: "Effective bearing area of foundation"}

            dict["H"] = {param: "H", description: "Horizontal load on foundation"}
            dict["Htheta_rad"] = {param: "Htheta_rad", description: "Angle of horizontal load in plan (from length)"}
            
            dict["c"] = {param: "c", description: "Drained cohesion"}
            dict["phi_rad"] = {param: "phi_rad", description: "Friction"}
                
            dict["g"] = {param: "g", description: "Effective density of soil"}
            dict["q"] = {param: "q", description: "Effective surcharge pressure"}
            dict["alpha_rad"] = {param:"alpha_rad", description: "Angle of inclination of base of foundation (0=horizontal)"}
            
            return dict;
        }
        
        function_descriptions () {
            var dict = {
                func:"",
                description:"",
                limitations:"",
                reference:"",
                category:""
             };
             
             var catName = "Bearing Capacity"

            dict["calc_EC7_D2_nc"] = {func: "calc_EC7_D2_nc",description: "calculate nc factor for EC7 Eq D2", category: catName}
            dict["calc_EC7_D2_ic"] = {func: "calc_EC7_D2_ic",description: "calculate inclination of load factor ic caused by H for EC7 Eq D2", category: catName}
            dict["calc_EC7_D2_sc"] = {func: "calc_EC7_D2_sc",description: "calculate shape factor sc for EC7 Eq D2", category: catName}
            dict["calc_EC7_D2_bc"] = {func: "calc_EC7_D2_bc",description: "calculate inclined foundation factor bc for EC7 Eq D2", category: catName}
                    
            dict["calc_EC7_D2_nq"] = {func: "calc_EC7_D2_nq",description: "calculate nq factor for EC7 Eq D2", category: catName}
            dict["calc_EC7_D2_iq"] = {func: "calc_EC7_D2_iq",description: "calculate inclination of load factor iq caused by H for EC7 Eq D2", category: catName}
            dict["calc_EC7_D2_sq"] = {func: "calc_EC7_D2_sq",description: "calculate shape factor sq for EC7 Eq D2", category: catName}
            dict["calc_EC7_D2_bq"] = {func: "calc_EC7_D2_bq",description: "calculate inclined foundation factor bq for EC7 Eq D2", category: catName}
                    
            dict["calc_EC7_D2_ng"] = {func: "calc_EC7_D2_ng",description: "calculate ng factor for EC7 Eq D2", category: catName}
            dict["calc_EC7_D2_ig"] = {func: "calc_EC7_D2_ig",description: "calculate inclination of load factor ig caused by H for EC7 Eq D2", category: catName}
            dict["calc_EC7_D2_sg"] = {func: "calc_EC7_D2_sg",description: "calculate shape factor sg for EC7 Eq D2", category: catName}
            dict["calc_EC7_D2_bg"] = {func: "calc_EC7_D2_bg",description: "calculate inclined foundation factor bg for EC7 Eq D2", category: catName}
                    
            dict["calc_EC7_D2_qnc"] = {func: "calc_EC7_D2_qnc",description: "calculate design drained bearing resistance for cohesive component qnc EC7 Eq D2", category: catName}
            dict["calc_EC7_D2_qnq"] = {func: "calc_EC7_D2_qnq",description: "calculate design drained bearing resistance for surcharge component qnq EC7 Eq D2", category: catName}
            dict["calc_EC7_D2_qng"] = {func: "calc_EC7_D2_qng",description: "calculate design drained bearing resistance for width component qng EC7 Eq D2", category: catName}
            dict["calc_EC7_D2"] = {func: "calc_EC7_D2",description: "calculate design drained bearing resistance for EC7 Eq D2", category: catName}

             return dict;
        }
            // 'Input variables
            set c (dNewValue) {this._c = dNewValue;}
            set phi_rad (dNewValue) {this._phi_rad = dNewValue;}
            set q (dNewValue) {this._q = dNewValue;}
            set G (dNewValue) {this._G = dNewValue;}
            set L (dNewValue) {this._L = dNewValue;}
            set B (dNewValue) {this._B = dNewValue;}
            set a (dNewValue) {this._a = dNewValue;}
            set H (dNewValue) {this._H = dNewValue;}
            set V (dNewValue) {this._V = dNewValue;}
            set alpha_rad (dNewValue) {this._alpha_rad = dNewValue;}
            set Htheta_rad (dNewValue) {this._Htheta_rad = dNewValue;}
            
            // ' Output Variables
            get sc() {return this._Sc;}
            get nc() {return this._nc;}
            get bc() {return this._bc;}
            get ic() {return this._Ic;}
            get sq() {return this._sq;}
            get Nq() {return this._nq;}
            get bq() {return this._bq;}
            get iq() {return this._iq;}
            get sg() {return this._sg;}
            get Ng() {return this._ng;}
            get bg() {return this._bg;}
            get ig() {return this.ig;}
            get q_nc() {return this._q_nc;}
            get q_ng() {return this._q_ng;}
            get q_nq() {return this._q_nq;}
            get q_ult() {return this._q_ult}
    
    // ' Calculations for D2
    
    calc_D2_nq()    {
        this._nq = Math.exp(this._const_PI * Math.tan(this._phi_rad)) * (Math.tan(this._const_PI / 4 + this._phi_rad / 2)) ^ 2;
        return this._nq;
    }
    
    calc_D2_nc()    {
        this._nc = (this._nq - 1) / Math.tan(this._phi_rad);
        return this._nc;
    }
    
    calc_D2_ng()    {
        this._ng = 2 * (this._nq - 1) * Math.tan(this._phi_rad);
        return this._ng;
    }
    
    calc_D2_bq()    {
        this._bq = (1 - this._alpha_rad * Math.tan(this._phi_rad)) ^ 2;
        return this._bq;
    }
    
    calc_D2_bc()    {
        this._bc = this._bq - (1 - this._bq) / (this._nc * Math.tan(this._phi_rad));
        return this._bc;
    }
    
    calc_D2_bg()    {
        this._bg = (1 - this._alpha_rad * Math.tan(this._phi_rad)) ^ 2;
        return this._bg;
    }
    
    calc_D2_sq()    {
        this._sq = 1 + (this._B / this._L) * Math.sin(this._phi_rad);
        return this._sq;
    }
    
    calc_D2_sg()    {
        this._sg = 1 - 0.3 * (this._B / this._L);
        return this._sg;
    }
    
    calc_D2_sc()    {
        this._Sc = (this._sq * this._nq - 1) / (this._nq - 1);
        return this._Sc;
    }
    
    calc_D2_ic()    {
        if (this._iq > 0 ) {
        this._Ic = this._iq - (1 - this._iq) / (this._nc * Math.tan(this._phi_rad))
        } else {
        this._Ic = 1
        }
    
        return this._Ic;
    }
    
    calc_D2_iq() {
    
    var H_temp = (this._V + this._a * this._c / Math.tan(this._phi_rad));
    
        if (H_temp = 0) {
        this._iq = 1;
        } else {
            if (1 - this._H / H_temp > 0) {
                this._iq = (1 - this._H / H_temp) ^ this._M;
            } else {
                this._iq = 0;
            }
        }
    
    return this._iq
    }
    
    
    calc_D2_ig()    {
    
    var H_temp = (this._V + this._a * this._c / Math.tan(this._phi_rad));
    
    if (H_temp == 0) {
        this._ig = 1;
    } else {
        if (1 - this._H / H_temp > 0) {
        this._ig = (1 - this._H / H_temp) ^ (this._M + 1);
        } else {
        this._ig = 0;
        }
    }
    
    return this._ig;
    
    }
    
    calc_D2_m(){
        this._mb = (2 + (this._B / this._L)) / (1 + (this._B / this._L));
        this._ml = (2 + (this._L / this._B)) / (1 + (this._L / this._B));
        this._M = this._ml * Math.cos(this._Htheta_rad) ^ 2 + this._mb * Math.sin(this._Htheta_rad) ^ 2;
        return this._M;
    }
    
    
    calc_D2_qnc()   {
    
        this.calc_D2_ng();
    
        this.calc_D2_nq();
        this.calc_D2_bq();
        this.calc_D2_sq();
        this.calc_D2_m();
        this.calc_D2_iq();
    
        this.calc_D2_nc();
        this.calc_D2_bc();
        this.calc_D2_sc();
        this.calc_D2_ic();
    
        this._q_nc = this._c * this._nc * this._bc * this._Sc * this._Ic;
        return this._q_nc;
    }
    
    calc_D2_qnq() {
        this.calc_D2_nq();
        this.calc_D2_bq();
        this.calc_D2_sq();
        this.calc_D2_m();
        this.calc_D2_iq();
        this._q_nq = this._q * this._nq * this._bq * this._sq * this._iq;
        return this._q_nq;
    }
    
    
    calc_D2_qng() {
        this.calc_D2_nq();
        this.calc_D2_ng();
        this.calc_D2_bg();
        this. calc_D2_sg();
        this.calc_D2_m();
        this.calc_D2_ig();
        this._q_ng = 0.5 * this._G * this._B * this._ng * this._bg * this._sg * this._ig;
        return this._q_ng;
    }
    
    calc_D2() {
        this.calc_D2_qng();
        this.calc_D2_qnq();
        this.calc_D2_qnc();
        this._q_ult = this._q_nc + this._q_nq + this._q_ng
        return this._q_ult;
    }
       
    
    }

class cEC7_UndrainedBearingResistanceD1 {
 
        constructor (data) {
        this._const_PI = 3.14159;
        this._Htheta_rad = this.const_PI / 2.00;
        
        if (data != null) {
            this._H = data.H
            this._Htheta_rad = data.Htheta_rad
            this._q = data.q
            this._B = data.B
            this._g = data.g
            this._q = data.q
            this._Cu = data.Cu
            this._a = data.a
            this._L = data.L
            this._alpha_rad = data.alpha_rad
        }

            
    }
        references () {
            var dict = {
                id: 0,
                reference:"" 
             };
             dict[1] = {id: 1, reference: "Design bearing resistances calculated from EC-7 EN 1997-1:2004 Annex D"}
             
             return dict;

        }
        
        limitations () {
            var dict = {
                id: 0,
                reference:"" 
             };
             dict[1] = {id: 1,limitation: "Ultimate limit state ONLY"}

             return dict;
        }

        param_descriptions () {
        
            var dict = {
               param:"",
               description:""
            };

            dict["L"] = {param: "L", description: "Effective length of foundation"}
            dict["B"] = {param: "B", description: "Effective breadth of foundation"}
            dict["a"] = {param: "a", description: "Effective bearing area of foundation"}

            dict["H"] = {param: "H", description: "Horizontal load on foundation"}
            dict["Htheta_rad"] = {param: "Htheta_rad", description: "Angle of horizontal load in plan (from length)"}
            
            dict["Cu"] = {param: "Cu", description: "Undrained cohesion"}
            dict["g"] = {param: "g", description: "Effective density of soil"}
            dict["q"] = {param: "q", description: "Effective surcharge pressure"}
            dict["alpha_rad"] = {param:"alpha_rad", description: "Angle of inclination of base of foundation (0=horizontal)"}
            
            return dict;
        }
        
        function_descriptions () {
            var dict = {
                func:"",
                description:"",
                limitations:"",
                reference:"",
                category:""
             };
             
             var catName = "Bearing Capacity"

            dict["calc_EC7_D1_nc"]= {func: "calc_EC7_D1_nc", description: "calculate nc factor for EC7 Eq D1", category: catName}
            dict["calc_EC7_D1_ic"] = {fun: "calc_EC7_D1_ic", description: "calculate inclination of load factor caused by H for EC7 Eq D1", category: catName}
            dict["calc_EC7_D1_sc"] = {func: "calc_EC7_D1_sc",description: "calculate shape factor sc for EC7 Eq D1", category: catName}
            dict["calc_EC7_D1_bc"] = {func: "calc_EC7_D1_bc",description: "calculate inclined foundation factor for EC7 Eq D1", category: catName}
            dict["calc_EC7_D1_qnc"] = {func: "calc_EC7_D1_qnc",description: "calculate design undrained bearing resistance for cohesive component nc_q EC7 Eq D1", category: catName}
            dict["calc_EC7_D1"] = {func: "calc_EC7_D1",description: "calculate design undrained bearing resistance for EC7 Eq D1", category: catName}
                    
            return dict;
        }
            // 'Input variables
            set Cu (dNewValue) {this._cu = dNewValue;}
            set phi_rad (dNewValue) {this._phi_rad = dNewValue;}
            set q (dNewValue) {this._q = dNewValue;}
            set G (dNewValue) {this._G = dNewValue;}
            set L (dNewValue) {this._L = dNewValue;}
            set B (dNewValue) {this._B = dNewValue;}
            set a (dNewValue) {this._a = dNewValue;}
            set H (dNewValue) {this._H = dNewValue;}
            set V (dNewValue) {this._V = dNewValue;}
            set alpha_rad (dNewValue) {this._alpha_rad = dNewValue;}
            set Htheta_rad (dNewValue) {this._Htheta_rad = dNewValue;}
            
            // ' Output Variables
            get sc() {return this._Sc;}
            get nc() {return this._nc;}
            get bc() {return this._bc;}
            get ic() {return this._Ic;}
            get sq() {return this._sq;}
            get Nq() {return this._nq;}
            get bq() {return this._bq;}
            get iq() {return this._iq;}
            get sg() {return this._sg;}
            get Ng() {return this._ng;}
            get bg() {return this._bg;}
            get ig() {return this.ig;}
            get q_nc() {return this._q_nc;}
            get q_ng() {return this._q_ng;}
            get q_nq() {return this._q_nq;}
            get q_ult() {return this._q_ult}
    
        
    // Undrained D1 Calculations
    calc_D1_nc()    {
        this._nc = this._const_PI + 2;
        return this._nc;
    }
    
    calc_D1()   {
        this.calc_D1_qnc();
        this._q_ult = this._q_nc + this._q;
        return this._q_ult;
    }
    
    calc_D1_qnc() {
        this.calc_D1_nc();
        this.calc_D1_bc();
        this.calc_D1_sc();
        this.calc_D1_ic();
        this._q_nc = (this._const_PI + 2) * this._Cu * this._bc * this._Sc * this._Ic;
        return this._q_nc
    }
    
    calc_D1_bc() {
        this._bc = 1 - 2 * this._alpha_rad / (this._const_PI + 2);
        return this._bc;
    }
    
    calc_D1_sc() {
        this._Sc = (1 + 0.2 * this._B / this._L);
        return this._Sc;
    }
    
    calc_D1_ic() {
        
        if (this._H < this._a * this._c) {
            this._Ic = 0.5 * (1 + (1 - this._H / (this._a * this._c)) ^ 0.5);
        } else  {
            this._Ic = 0.5;
        }
        
        return this._Ic;
    }
    
    }
    module.exports =    

    class mEC7_Bearing {

    // "Function for Calculating Bearing Capcity in accordance with EC7 Annex D"


    static check() {

        var ec7 = new cEC7_Bearing_Capacity();

        ec7.H = 375;
        ec7.c = 0.001;
        ec7.a = 12;
        ec7.L = 10;
        ec7.B = 1;
        ec7.Htheta_rad = 0;
        ec7.phi_rad = 0.5159;
        
        ec7.calc_D2_m;
        ec7.calc_D2_iq;
          
        return ec7.iq;
    
    }

static Check_EC7_Bearing() {
        
        var ec7 = new cEC7_Bearing_Capacity();

        ec7.c = 0;
        ec7.phi_rad = 0.5235;
        ec7.G = 8;
        ec7.q = 8 * 1.8;
    
        ec7.v = 2816.15;
        ec7.H = 230.4;
    
        ec7.B = 3.263;
        ec7.L = 3.292;
        ec7.a = 10.75;
    
        ec7.calc_D2;
    
        console.log (ec7.q_nc, ec7.q_nq, ec7.q_ng, ec7.q_ult);
        
        ec7 = Nothing
}


static init_functions (name  = "Geotech EC7 Bearing Resistance") {

// If Len(catName) = 0 Then catName = "Geotech EC7 Bearing Resistance"
// With ThisWorkbook
//         .IsAddin = False
// End With

// With Application
// ]
//         .MacroOptions Macro:="calc_EC7_D1_nc", Description:="calculate nc factor for EC7 Eq D1", Category:=catName
//         .MacroOptions Macro:="calc_EC7_D1_ic", Description:="calculate inclination of load factor caused by H for EC7 Eq D1", Category:=catName
//         .MacroOptions Macro:="calc_EC7_D1_sc", Description:="calculate shape factor sc for EC7 Eq D1", Category:=catName
//         .MacroOptions Macro:="calc_EC7_D1_bc", Description:="calculate inclined foundation factor for EC7 Eq D1", Category:=catName
        
//         .MacroOptions Macro:="calc_EC7_D1_qnc", Description:="calculate design undrained bearing resistance for cohesive component nc_q EC7 Eq D1", Category:=catName
//         .MacroOptions Macro:="calc_EC7_D1", Description:="calculate design undrained bearing resistance for EC7 Eq D1", Category:=catName
        
//         .MacroOptions Macro:="calc_EC7_D2_nc", Description:="calculate nc factor for EC7 Eq D2", Category:=catName
//         .MacroOptions Macro:="calc_EC7_D2_ic", Description:="calculate inclination of load factor ic caused by H for EC7 Eq D2", Category:=catName
//         .MacroOptions Macro:="calc_EC7_D2_sc", Description:="calculate shape factor sc for EC7 Eq D2", Category:=catName
//         .MacroOptions Macro:="calc_EC7_D2_bc", Description:="calculate inclined foundation factor bc for EC7 Eq D2", Category:=catName
        
//         .MacroOptions Macro:="calc_EC7_D2_nq", Description:="calculate nq factor for EC7 Eq D2", Category:=catName
//         .MacroOptions Macro:="calc_EC7_D2_iq", Description:="calculate inclination of load factor iq caused by H for EC7 Eq D2", Category:=catName
//         .MacroOptions Macro:="calc_EC7_D2_sq", Description:="calculate shape factor sq for EC7 Eq D2", Category:=catName
//         .MacroOptions Macro:="calc_EC7_D2_bq", Description:="calculate inclined foundation factor bq for EC7 Eq D2", Category:=catName
        
//         .MacroOptions Macro:="calc_EC7_D2_ng", Description:="calculate ng factor for EC7 Eq D2", Category:=catName
//         .MacroOptions Macro:="calc_EC7_D2_ig", Description:="calculate inclination of load factor ig caused by H for EC7 Eq D2", Category:=catName
//         .MacroOptions Macro:="calc_EC7_D2_sg", Description:="calculate shape factor sg for EC7 Eq D2", Category:=catName
//         .MacroOptions Macro:="calc_EC7_D2_bg", Description:="calculate inclined foundation factor bg for EC7 Eq D2", Category:=catName
        
//         .MacroOptions Macro:="calc_EC7_D2_qnc", Description:="calculate design drained bearing resistance for cohesive component qnc EC7 Eq D2", Category:=catName
//         .MacroOptions Macro:="calc_EC7_D2_qnq", Description:="calculate design drained bearing resistance for surcharge component qnq EC7 Eq D2", Category:=catName
//         .MacroOptions Macro:="calc_EC7_D2_qng", Description:="calculate design drained bearing resistance for width component qng EC7 Eq D2", Category:=catName
//         .MacroOptions Macro:="calc_EC7_D2", Description:="calculate design drained bearing resistance for EC7 Eq D2", Category:=catName





// End With

//  With ThisWorkbook
//         .IsAddin = True
//  End With

}

static calc_EC7_D1_nc() {
        
        // Attribute calc_EC7_D1_nc.VB_Description = "calculate nc factor for EC7 Eq D1"
        // Attribute calc_EC7_D1_nc.VB_ProcData.VB_Invoke_Func = " \n21"

        var ec7 = new cEC7_UndrainedBearingResistanceD1();
        return ec7.calc_D1_nc();
}


static calc_EC7_D1_ic(  H, Cu, a) {

        // Attribute calc_EC7_D1_ic.VB_Description = "calculate inclination of load factor caused by H for EC7 Eq D1"
        // Attribute calc_EC7_D1_ic.VB_ProcData.VB_Invoke_Func = " \n21"

        var ec7 = new cEC7_UndrainedBearingResistanceD1();
        ec7.H = H
        ec7.c = Cu
        ec7.a = a
        return ec7.calc_D1_ic();
}

static calc_EC7_D1_sc(B, L) {

        // Attribute calc_EC7_D1_sc.VB_Description = "calculate shape factor sc for EC7 Eq D1"
        // Attribute calc_EC7_D1_sc.VB_ProcData.VB_Invoke_Func = " \n21"

        var ec7 = new cEC7_UndrainedBearingResistanceD1();
        ec7.L = L
        ec7.B = B
        return ec7.calc_D1_sc();
}


static calc_EC7_D1_bc(alpha_rad) {
        
        // Attribute calc_EC7_D1_bc.VB_Description = "calculate inclined foundation factor for EC7 Eq D1"
        // Attribute calc_EC7_D1_bc.VB_ProcData.VB_Invoke_Func = " \n21"

        var ec7 = new cEC7_UndrainedBearingResistanceD1();
        ec7.alpha_rad = alpha_rad
        return ec7.calc_D1_bc();

}

// https://stackoverflow.com/questions/10855908/how-to-overload-functions-in-javascript
// data: function(key, value) {
//     if (arguments.length === 0) {
//         // .data()
//         // no args passed, return all keys/values in an object
//     } else if (typeof key === "string") {
//         // first arg is a string, look at type of second arg
//         if (typeof value !== "undefined") {
//             // .data("key", value)
//             // set the value for a particular key
//         } else {
//             // .data("key")
//             // retrieve a value for a key
//         }
//     } else if (typeof key === "object") {
//         // .data(object)
//         // set all key/value pairs from this object
//     } else {
//         // unsupported arguments passed
//     }
// }

static calc_EC7_D1_data (data) { 

    var ec7 = new cEC7_UndrainedBearingResistanceD1();

    ec7.calc_D1();

    return ec7;
}

static calc_EC7_D1 (H, Cu, a, B, L, q, alpha_rad ) {

        // Attribute calc_EC7_D1.VB_Description = "calculate design undrained bearing resistance for EC7 Eq D1"
        // Attribute calc_EC7_D1.VB_ProcData.VB_Invoke_Func = " \n21"

        var ec7 = new cEC7_UndrainedBearingResistanceD1();
        ec7.H = H
        ec7.q = q
        ec7.B = B
        ec7.c = Cu
        ec7.a = a
        ec7.L = L
        ec7.alpha_rad = alpha_rad
        return ec7.calc_D1();
}

static calc_EC7_D1_qnc(H, Cu, a, B, L, alpha_rad ) {

        // Attribute calc_EC7_D1_qnc.VB_Description = "calculate design undrained bearing resistance for cohesive component nc_q EC7 Eq D1"
        // Attribute calc_EC7_D1_qnc.VB_ProcData.VB_Invoke_Func = " \n21"

        var ec7 = new cEC7_UndrainedBearingResistanceD1();
        ec7.H = H
        ec7.c = Cu
        ec7.B = B
        ec7.a = a
        ec7.L = L
        ec7.alpha_rad = alpha_rad
        return ec7.calc_D1_qnc();
}



static calc_EC7_D2_nc(phi_rad ) {
        // Attribute calc_EC7_D2_nc.VB_Description = "calculate nc factor for EC7 Eq D2"
        // Attribute calc_EC7_D2_nc.VB_ProcData.VB_Invoke_Func = " \n21"

        var ec7 = new cEC7_DrainedBearingResistanceD2();
        ec7.phi_rad = phi_rad
        ec7.calc_D2_nq
        return ec7.calc_D2_nc();
}

static calc_EC7_D2_ic(v, H, c, a, phi_rad, Htheta_rad, B, L ) {
        // Attribute calc_EC7_D2_ic.VB_Description = "calculate inclination of load factor ic caused by H for EC7 Eq D2"
        // Attribute calc_EC7_D2_ic.VB_ProcData.VB_Invoke_Func = " \n21"

        var ec7 = new cEC7_DrainedBearingResistanceD2();
        ec7.phi_rad = phi_rad
        ec7.calc_D2_nq
        ec7.calc_D2_nc
        
        ec7.B = B
        ec7.L = L
        ec7.Htheta_rad = Htheta_rad
        ec7.calc_D2_m
        
        ec7.H = H
        ec7.c = c
        ec7.a = a
        ec7.v = v
        ec7.calc_D2_iq

        return ec7.calc_D2_ic();

}

static calc_EC7_D2_sc(phi_rad, alpha_rad, B, L ) {
        
        // Attribute calc_EC7_D2_sc.VB_Description = "calculate shape factor sc for EC7 Eq D2"
        // Attribute calc_EC7_D2_sc.VB_ProcData.VB_Invoke_Func = " \n21"

        var ec7 = new cEC7_DrainedBearingResistanceD2();
        ec7.alpha_rad = alpha_rad;
        ec7.phi_rad = phi_rad;
        ec7.B = B;
        ec7.L = L;
        ec7.calc_D2_nq();
        ec7.calc_D2_sq();
        return ec7.calc_D2_sc();

}

static calc_EC7_D2_bc(phi_rad, alpha_rad ) {

        // Attribute calc_EC7_D2_bc.VB_Description = "calculate inclined foundation factor bc for EC7 Eq D2"
        // Attribute calc_EC7_D2_bc.VB_ProcData.VB_Invoke_Func = " \n21"

        var ec7 = new cEC7_DrainedBearingResistanceD2();
        ec7.phi_rad = phi_rad
        ec7.alpha_rad = alpha_rad
        ec7.calc_D2_nq();
        ec7.calc_D2_nc();
        ec7.calc_D2_bq();
        return ec7.calc_D2_bc();
}

static calc_EC7_D2_nq(phi_rad ) {

        // Attribute calc_EC7_D2_nq.VB_Description = "calculate nq factor for EC7 Eq D2"
        // Attribute calc_EC7_D2_nq.VB_ProcData.VB_Invoke_Func = " \n21"

        var ec7 = new cEC7_DrainedBearingResistanceD2();
        ec7.phi_rad = phi_rad
        return ec7.calc_D2_nq();
}

static calc_EC7_D2_iq(B, L, H, v, c, a, phi_rad, Htheta_rad ) {

        // Attribute calc_EC7_D2_iq.VB_Description = "calculate inclination of load factor iq caused by H for EC7 Eq D2"
        // Attribute calc_EC7_D2_iq.VB_ProcData.VB_Invoke_Func = " \n21"

        var ec7 = new cEC7_DrainedBearingResistanceD2();

        ec7.H = H
        ec7.c = c
        ec7.a = a
        ec7.L = L
        ec7.B = B
        ec7.v = v
        ec7.Htheta_rad = Htheta_rad
        ec7.phi_rad = phi_rad
        ec7.calc_D2_m
        return ec7.calc_D2_iq();
}

static calc_EC7_D2_sq(phi_rad, B, L ) {

        // Attribute calc_EC7_D2_sq.VB_Description = "calculate shape factor sq for EC7 Eq D2"
        // Attribute calc_EC7_D2_sq.VB_ProcData.VB_Invoke_Func = " \n21"

        var ec7 = new cEC7_DrainedBearingResistanceD2();
        ec7.phi_rad = phi_rad
        ec7.B = B
        ec7.L = L
        return ec7.calc_D2_sq();
}

static calc_EC7_D2_bq(phi_rad, alpha_rad ) {

        // Attribute calc_EC7_D2_bq.VB_Description = "calculate inclined foundation factor bq for EC7 Eq D2"
        // Attribute calc_EC7_D2_bq.VB_ProcData.VB_Invoke_Func = " \n21"

        var ec7 = new cEC7_DrainedBearingResistanceD2();
        ec7.phi_rad = phi_rad
        ec7.alpha_rad = alpha_rad
        return ec7.calc_D2_bq();
}


static calc_EC7_D2_ng(phi_rad ) {

        // Attribute calc_EC7_D2_ng.VB_Description = "calculate ng factor for EC7 Eq D2"
        // Attribute calc_EC7_D2_ng.VB_ProcData.VB_Invoke_Func = " \n21"

        var ec7 = new cEC7_DrainedBearingResistanceD2();
        ec7.phi_rad = phi_rad
        ec7.calc_D2_nq
        return ec7.calc_D2_ng();

}
static calc_EC7_D2_ig(B, L, H, v, c, a, phi_rad, Htheta_rad ) {

        // Attribute calc_EC7_D2_ig.VB_Description = "calculate inclination of load factor ig caused by H for EC7 Eq D2"
        // Attribute calc_EC7_D2_ig.VB_ProcData.VB_Invoke_Func = " \n21"

        var ec7 = new cEC7_DrainedBearingResistanceD2();
        ec7.H = H
        ec7.c = c
        ec7.a = a
        ec7.L = L
        ec7.B = B
        ec7.v = v
        ec7.Htheta_rad = Htheta_rad
        ec7.phi_rad = phi_rad
        ec7.calc_D2_m
        return ec7.calc_D2_ig();

}
static calc_EC7_D2_sg(B, L ) {

        // Attribute calc_EC7_D2_sg.VB_Description = "calculate shape factor sg for EC7 Eq D2"
        // Attribute calc_EC7_D2_sg.VB_ProcData.VB_Invoke_Func = " \n21"

        var ec7 = new cEC7_DrainedBearingResistanceD2();
        ec7.B = B
        ec7.L = L
        return ec7.calc_D2_sg();
}
static calc_EC7_D2_bg(phi_rad, alpha_rad ) {

        // Attribute calc_EC7_D2_bg.VB_Description = "calculate inclined foundation factor bg for EC7 Eq D2"
        // Attribute calc_EC7_D2_bg.VB_ProcData.VB_Invoke_Func = " \n21"

        var ec7 = new cEC7_DrainedBearingResistanceD2();
        ec7.phi_rad = phi_rad
        ec7.alpha_rad = alpha_rad
        return ec7.calc_D2_bg();

}
static calc_EC7_D2_qnc(B, L, H, v, c, a, phi_rad, Htheta_rad, alpha_rad ) {

        // Attribute calc_EC7_D2_qnc.VB_Description = "calculate design drained bearing resistance for cohesive component qnc EC7 Eq D2"
        // Attribute calc_EC7_D2_qnc.VB_ProcData.VB_Invoke_Func = " \n21"

        var ec7 = new cEC7_DrainedBearingResistanceD2();
        ec7.c = c
        ec7.phi_rad = phi_rad
        ec7.B = B
        ec7.L = L
        ec7.a = a
        ec7.v = v
        ec7.H = H
        ec7.alpha_rad = alpha_rad
        ec7.Htheta_rad = Htheta_rad
        return  ec7.calc_D2_qnc();
}

static calc_EC7_D2_qnq(B, L, a, H, v, c, phi_rad, Htheta_rad, alpha_rad, q) {

        // Attribute calc_EC7_D2_qnq.VB_Description = "calculate design drained bearing resistance for surcharge component qnq EC7 Eq D2"
        // Attribute calc_EC7_D2_qnq.VB_ProcData.VB_Invoke_Func = " \n21"

        var ec7 = new cEC7_DrainedBearingResistanceD2();
        ec7.c = c
        ec7.phi_rad = phi_rad
        ec7.q = q
        ec7.B = B
        ec7.L = L
        ec7.a = a
        ec7.v = v
        ec7.H = H
        ec7.alpha_rad = alpha_rad
        ec7.Htheta_rad = Htheta_rad
        return ec7.calc_D2_qnq();

}
static calc_EC7_D2_qng(B, L, a, H, v, c, phi_rad, Htheta_rad, alpha_rad, G) {
        
        // Attribute calc_EC7_D2_qng.VB_Description = "calculate design drained bearing resistance for width component qng EC7 Eq D2"
        // Attribute calc_EC7_D2_qng.VB_ProcData.VB_Invoke_Func = " \n21"

        var ec7 = new cEC7_DrainedBearingResistanceD2();
        ec7.c = c
        ec7.phi_rad = phi_rad
        ec7.G = G
        ec7.B = B
        ec7.L = L
        ec7.a = a
        ec7.v = v
        ec7.H = H
        ec7.alpha_rad = alpha_rad
        ec7.Htheta_rad = Htheta_rad
        return ec7.calc_D2_qng();

}
static calc_EC7_D2_data (data) { 

    var ec7 = new cEC7_DrainedBearingResistanceD2(data);

    return ec7.calc_D2();
}
static calc_EC7_D2(B, L, a, H, v, c, phi_rad, Htheta_rad, alpha_rad, q, G) {

        // Attribute calc_EC7_D2.VB_Description = "calculate design drained bearing resistance for EC7 Eq D2"
        // Attribute calc_EC7_D2.VB_ProcData.VB_Invoke_Func = " \n21"

        var ec7 = new cEC7_DrainedBearingResistanceD2();

        ec7.c = c
        ec7.phi_rad = phi_rad
        ec7.G = G
        ec7.q = q
        ec7.B = B
        ec7.L = L
        ec7.a = a
        ec7.v = v
        ec7.H = H
        ec7.alpha_rad = alpha_rad
        ec7.Htheta_rad = Htheta_rad
        return ec7.calc_D2();

}

}

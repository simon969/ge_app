    
    //const host = 'https://ge-node.azurewebsites.net/api';
    const host = 'http://emi-gis-ps.scottwilson.co.uk:3000/api';
    // const host = 'http://localhost:3000/api';
    
    // const py_host = 'https://ge-py.azurewebsites.net';
    const py_host = 'http://emi-gis-ps.scottwilson.co.uk:8000';
    //const py_host = 'http://localhost:8000';
    // const ge_host = 'http://localhost:5000';
    const ge_host = 'http://emi-gis-ps.scottwilson.co.uk:80/ge_gint4/api';

    class Status {
        static FAIL = -1
        static READY = 0
        static PROCESSING = 1
        static SUCCESS = 2
    }
    function get_status (s){
        if (s==Status.FAIL) return 'FAIL'
        if (s==Status.READY) return 'READY'
        if (s==Status.PROCESSING) return 'PROCESSING'
        if (s==Status.SUCCESS) return 'SUCCESS'
    }
    function radians(deg) {
        return deg * Math.PI / 180.0 
    }

    function set_visible(id, value) {
        var e = document.getElementById(id);
        if (e != null) {
            e.setAttribute('visible', value);
        }
    }
  
    function set_value( id, value) {
        var e = document.getElementById(id);
        e.setAttribute('value', value);
        e.value = value;
    }
    function set_href( id, value) {
        var e = document.getElementById(id);
        e.setAttribute('href', value);
    }
    function set_attribute( id, attribute, value) {
        var e = document.getElementById(id);
        if (e != null) {
        e.setAttribute(attribute, value);
        }
    }
    function set_innerHTML( id, value) {
        var e = document.getElementById(id);
        if (e != null) {
            e.innerHTML = value;
        }
    }
    function set_innerText ( id, value) {
        var e = document.getElementById(id);
        if (e != null) {
            e.innerText = value;
        }
    }
    function get_value(id) {
        var e = document.getElementById(id);
        if (e != null) {
            // return e.getAttribute('value');
            return e.value;
        }

    } 
    function get_paired_floats(x_vals, y_vals) {
        var a = []
        for (let i = 0; i < x_vals.length; i++) {
            var el = new Object
            el.x = ParseFloat(x_vals[i]);
            el.y = ParseFloat(y_vals[i]);
            a[i] = el;
        } 

    }

    function update_file_list(file, filelist) {

        var input = document.getElementById(file);
        var output = document.getElementById(filelist);
        var children = "";
        for (var i = 0; i < input.files.length; ++i) {
            children += '<li>' + input.files.item(i).name + ' (' + input.files.item(i).size /1000 + ' Kb) </li>';
        }
        output.innerHTML = '<ul>'+children+'</ul>';
    }
    function update_file_list2(file, filelist) {
        var x = document.getElementById(file);
        var txt = "";
        if ('files' in x) {
            if (x.files.length == 0) {
                txt = "Select one or more files.";
            } else {
                for (var i = 0; i < x.files.length; i++) {
                txt += "<br><strong>" + (i+1) + ". file</strong><br>";
                var file = x.files[i];
                if ('name' in file) {
                    txt += "name: " + file.name + "<br>";
                }
                if ('size' in file) {
                    txt += "size: " + file.size + " bytes <br>";
                }
                }
            }
        }
        document.getElementById (filelist).innerHTML = txt;
    }
    function update_file_list3(file, filelist) {
        var x = document.getElementById(file);
        var lst = document.getElementById(filelist);
        if ('files' in x) {
            if (x.files.length > 0) {
                for (var i = 0; i < x.files.length; i++) {
                var file = x.files[i];
                li = document.createElement('li');
                li.setAttribute("class", "list-group-item");
                    var a = document.createElement('a');
                    var link = document.createTextNode(file.name);
                    a.title = file.size
                    a.appendChild(link); 
                    li.appendChild(a)
                lst.appendChild(li);
                }
            }
        }
    }
    function httpGetAsync(theUrl, callback)
    {
            var xmlHttp = new XMLHttpRequest();
            xmlHttp.onreadystatechange = function() { 
                if (xmlHttp.readyState == 4 && xmlHttp.status == 200)
                    callback(xmlHttp.responseText);
            }
            console.log(theUrl);
            xmlHttp.open("GET", theUrl, true); // true for asynchronous 
           // xmlHttp.setRequestHeader("Access-Control-Allow-Origin", "http://localhost:5002")
            xmlHttp.send(null);
    }
    
    function httpGet(theUrl)
    {
            var xmlHttp = new XMLHttpRequest();
            console.log(theUrl);
            xmlHttp.open("GET", theUrl, false); // false for synchronous 
            xmlHttp.send(null);
            return xmlHttp.responseText;
    }
    function httpPost(theUrl, body)
    {
            var xmlHttp = new XMLHttpRequest();
            console.log(theUrl);
            xmlHttp.open("POST", theUrl, false); // false for synchronous 
           
            xmlHttp.send(body);
            return xmlHttp.responseText;
    }
    function httpDelete(theUrl, body)
    {
            var xmlHttp = new XMLHttpRequest();
            console.log(theUrl);
            xmlHttp.open("DELETE", theUrl, false); // false for synchronous 
           
            xmlHttp.send(body);
            return xmlHttp.responseText;
    }
    function httpPostAsync(url, body, callback, content_type='application/json') {
            var xhr = new XMLHttpRequest();
            xhr.onreadystatechange = function() { 
            if (xhr.readyState == XMLHttpRequest.DONE) {
                    callback(xhr.responseText);
                    // var status = xhr.status;
                    // if (status === 0 || (status >= 200 && status < 400)) {
                    //     // The request has been completed successfully
                    //     console.log(xhr.responseText); 
                    //     callback(xhr.responseText);
                    // } else {
                    //     // Oh no! There has been an error with the request!
                    //     callback('{"error":"status code ' + status + '","message":"none"}');
                    // }
            }
            }
            xhr.onerror= function(e) {
                callback ('{"error":" error fetching ' + url + '","message":"' + e.message + '"}');
            };
            
            try {
            xhr.open("POST", url, true); // true for asynchronous 
            // xmlHttp.setRequestHeader("X-CSRFToken", csrftoken);
            if (content_type!="") {
                xhr.setRequestHeader('Accept', content_type);
                xhr.setRequestHeader('Content-Type', content_type);
            }
            xhr.send(body);
            } catch (e) {
                alert (e);
            }
           
    }

    function initOkata() {
        // https://github.com/okta/okta-signin-widget#embedded-self-hosted   
        var signIn = new OktaSignIn(
        {
            baseUrl: 'https://dev-312326.okta.com',
            clientId: '0oa6f722ndf2hSUzW4x7',
            redirectUri: 'http://localhost:5002'
        }
        );

        signIn.showSignInToGetTokens({
        // Assumes there is an empty element on the page with an id of 'osw-container'
        el: '#osw-container'
        }).then(function(tokens) {
        // Store tokens
        }).catch(function(error) {
        // Handle error
        });
    }
 
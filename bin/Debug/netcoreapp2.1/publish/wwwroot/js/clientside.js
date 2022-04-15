
    //const host = 'https://ge-node.azurewebsites.net/api';
    // const host = 'http://emi-gis-ps.scottwilson.co.uk:3000/api';
    const host = 'http://localhost:3000/api';
    
    // const py_host = 'https://ge-py.azurewebsites.net';
    const py_host = 'http://emi-gis-ps.scottwilson.co.uk:8000';
    
    // const py_host = 'http://localhost:8000';
    // const gint_host = 'http://localhost:5000/api';
    const gint_host = 'http://emi-gis-ps.scottwilson.co.uk:80/ge_gint4/api';
    
    // const repo_host = 'http://localhost:5000/api';
    const repo_host = 'http://emi-gis-ps.scottwilson.co.uk:80/ge_repo/api';
  
    var token = null;
    var user = null;
    
    var OAuth2Client_gINT = {
            client_id : '0oa6ftjshgwk9supA4x7',
            client_secret : 'MTkiHq0m1x7gFWR0yXyDXDtCuGyUR418TkFhcJgJ',
            oauth2_url : 'https://dev-312326.okta.com/oauth2/aus6i9nii2BVLF0hZ4x7/v1/token',
            grant_type : 'client_credentials',
            scope : '',
            token : ''   
            };

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
    function get_token (OAuthClient) {
        
        // creates an object

        let formdata = new FormData(); 
        
        formdata.append('client_id', OAuthClient.client_id);
        formdata.append ('client_secret',OAuthClient.client_secret);
        formdata.append ('client_credentials',OAuthClient.client_credentials);
        formdata.append('scope', OAuthClient.scope); 

        var xhr = new XMLHttpRequest();
        
        xhr.open("POST", OAuthClient.oauth2_url, false); // false for synchronous 
        xhr.setRequestHeader("Content-type", "application/x-www-form-urlencoded");
        xhr.send(formdata);
        
        if (xhr.readyState == 4 && xhr.status == 200) {
            OAuthClient.token = xhr.responseText;
            return OAuthClient.token;
        }
    }

    function test_OktaCORS () {
    var baseUrl = 'https://dev-312326.okta.com';
        var xhr = new XMLHttpRequest();
        if ("withCredentials" in xhr) {
            xhr.onerror = function() {
            alert('Invalid URL or Cross-Origin Request Blocked.  You must explicitly add this site (' + window.location.origin + ') to the list of allowed websites in the administrator UI');
            }
            xhr.onload = function() {
                alert(this.responseText);
            };
            xhr.open('GET', baseUrl + '/api/v1/users/me', true);
            xhr.withCredentials = true;
            xhr.send();
        } else {
            alert("CORS is not supported for this browser!")
        }
    }

    function httpGetAsync(theUrl, callback)
    {
            var xhr = new XMLHttpRequest();
            var token = get_value('token')
            var user = get_value ('user')
            xhr.onreadystatechange = function() { 
                if (xhr.readyState == 4 && xhr.status == 200)
                    callback(xhr.responseText);
            }
            console.log(theUrl);
            xhr.open("GET", theUrl, true); // true for asynchronous
            if (token) {
                xhr.setRequestHeader ('Authorization',`Bearer ${token}`)
            } 
            if (user) {
                xhr.setRequestHeader ("user",user)
            } 
            // xhr.setRequestHeader("Access-Control-Allow-Origin", "http://localhost:5002")
            xhr.send(null);
    }
    // function httpGetAsync(theUrl, callback)
    // {
    //         var xhr = new XMLHttpRequest();
    //         xhr.onreadystatechange = function() { 
    //             if (xhr.readyState == 4 && xhr.status == 200)
    //                 callback(xhr.responseText);
    //         }
    //         console.log(theUrl);
    //         xhr.open("GET", theUrl, true); // true for asynchronous 
    //         xhr.send(null);
    // }
    
    function httpGet(theUrl)
    {
            var xmlHttp = new XMLHttpRequest();
            console.log(theUrl);
            xhr.open("GET", theUrl, false); // false for synchronous 
            xhr.send(null);
            return xhr.responseText;
    }
    function httpPost(theUrl, body)
    {
            var xhr = new XMLHttpRequest();
            console.log(theUrl);
            xhr.open("POST", theUrl, false); // false for synchronous 
            if (token) {
                xhr.setRequestHeader ('Authorization',`Bearer ${token}`)
            } 
            if (user) {
                xhr.setRequestHeader ("user",user)
            } 
            xhr.send(body);
            return xhr.responseText;
    }
    function httpDelete(theUrl)
    {
            var xhr = new XMLHttpRequest();
            console.log(theUrl);
            xhr.open("DELETE", theUrl, false); // false for synchronous 
            xhr.send(null);
            return xhr.responseText;
    }
    function httpDeleteAsync(theUrl, callback)
    {
            var xhr = new XMLHttpRequest();
            xhr.onreadystatechange = function() { 
                if (xhr.readyState == XMLHttpRequest.DONE && callbackk)
                    callback(xhr.responseText);
            }
            console.log(theUrl);
            xhr.open("DELETE", theUrl, true); // true for asynchronous 
            xhr.send(null);
    }
    
    function httpPostAsync(url, body, callback, content_type='application/json') {
            var xhr = new XMLHttpRequest();
            xhr.onreadystatechange = function() { 
            if (xhr.readyState == XMLHttpRequest.DONE && callback) {
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
            if (token) {
                xhr.setRequestHeader ('Authorization',`Bearer ${token}`)
            } 
            if (user) {
                xhr.setRequestHeader ("user",user)
            } 
            // xhr.setRequestHeader("X-CSRFToken", csrftoken);
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

    function months(config) {
        var cfg = config || {};
        var count = cfg.count || 12;
        var section = cfg.section;
        var values = [];
        var i, value;
      
        for (i = 0; i < count; ++i) {
          value = MONTHS[Math.ceil(i) % 12];
          values.push(value.substring(0, section));
        }
      
        return values;
      }
      
      const COLORS = [
        '#4dc9f6',
        '#f67019',
        '#f53794',
        '#537bc4',
        '#acc236',
        '#166a8f',
        '#00a950',
        '#58595b',
        '#8549ba'
      ];
      
      function color(index) {
        return COLORS[index % COLORS.length];
      }
      
      function transparentize(value, opacity) {
        var alpha = opacity === undefined ? 0.5 : 1 - opacity;
        return colorLib(value).alpha(alpha).rgbString();
      }
      
      const CHART_COLORS = {
        red: 'rgb(255, 99, 132)',
        orange: 'rgb(255, 159, 64)',
        yellow: 'rgb(255, 205, 86)',
        green: 'rgb(75, 192, 192)',
        blue: 'rgb(54, 162, 235)',
        purple: 'rgb(153, 102, 255)',
        grey: 'rgb(201, 203, 207)'
      };
      
      const NAMED_COLORS = [
        CHART_COLORS.red,
        CHART_COLORS.orange,
        CHART_COLORS.yellow,
        CHART_COLORS.green,
        CHART_COLORS.blue,
        CHART_COLORS.purple,
        CHART_COLORS.grey,
      ];
      
      function namedColor(index) {
        return NAMED_COLORS[index % NAMED_COLORS.length];
      }
      
      function newDate(days) {
        return DateTime.now().plus({days}).toJSDate();
      }
      
      function newDateString(days) {
        return DateTime.now().plus({days}).toISO();
      }
      
      function parseISODate(str) {
        return DateTime.fromISO(str);
      }

      function open_pdf (latex_code) {
      var pdftex = new PDFTeX();
    //   var latex_code = "" +
    //     "\\documentclass{article}" +
    //     "\\begin{document}" +
    //     "\\LaTeX is great!" +
    //     "$E = mc^2$" +
    //     "\\end{document}";
      
      pdftex.compile(latex_code)
            .then(function(pdf) { window.open(pdf) })
      }
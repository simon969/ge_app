using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;
using System.Threading.Tasks;
namespace ge_app.Models
{
    public class ProcessModel {

        public string name {get; set;}
        public string description {get;set;}
        public string html_page {get; set;}
        public string version {get;set;}
        public string comments {get;set;}
        public DateTime release_date {get;set;}
        public string status {get;set;}
        public string controllers {get;set;}
    
    }
    public static class MyServer 
    {
        public static string MapPath(string path)
        {
            
            return Path.Combine(
                (string) AppDomain.CurrentDomain.GetData("ContentRootPath"), 
                path);
           

        }
    }
    public static class ProcessModelData { 
        public static IEnumerable<ProcessModel> items () {
            string file_json = Path.Combine( (string) AppDomain.CurrentDomain.GetData("ContentRootPath"),"static\\ProcessModelData.json");
                using (StreamReader r = new StreamReader(file_json))
                    {
                    string json = r.ReadToEnd();
                    IEnumerable<ProcessModel> items = JsonConvert.DeserializeObject<IEnumerable<ProcessModel>>(json);
                    return items;
                    }
        }
        public static ProcessModel item(string name) {
            return items().Where(item => item.name==name).SingleOrDefault();
        }
    public static List<ProcessModel> List(string controller = "") {

                        if (String.IsNullOrEmpty(controller)){
                            return items().ToList();
                        } else {
                            return items().Where(item => item.controllers.Contains(controller)).ToList();
                        }
    }    
    
    }
}
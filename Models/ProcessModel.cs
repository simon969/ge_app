using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;
using System.Linq;

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
        public static List<ProcessModel> List(string controller = "") {

            string file_json = Path.Combine( (string) AppDomain.CurrentDomain.GetData("ContentRootPath"),"static\\appdata\\ProcessModelData.json");
                using (StreamReader r = new StreamReader(file_json))
                    {
                    string json = r.ReadToEnd();
                    IEnumerable<ProcessModel> items = JsonSerializer.Deserialize<IEnumerable<ProcessModel>>(json);
                        if (String.IsNullOrEmpty(controller)){
                            return items.ToList();
                        } else {
                            return items.Where(item => item.controllers.Contains(controller)).ToList();
                        }
                    }
            
            
        }    
    }
//         var path = Server.MapPath("~/App_Data/Data.csv");
// var csvRows = System.IO.File.ReadAllLines(path, Encoding.Default).ToList();

    // public static ProcessModel[] Processes = {
    //         new ProcessModel {  name = "EC7 Bearing Resistance",
    //                             description ="",
    //                             html_page = "EC7_Bearing_Resistance.html",
    //                             controllers="BearingResistance"},
    //         new ProcessModel {  name = "EC7 Bearing Resistance",
    //                             description ="",
    //                             html_page = "",
    //                             controllers="BearingResistance"}                    
    //         };
    
    // }
}
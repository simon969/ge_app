using System;

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

    public class ProcessModelData {
    public static ProcessModel[] Processes = {
            new ProcessModel {  name = "EC7 Bearing Resistance",
                                description ="",
                                html_page = "EC7_Bearing_Resistance.html",
                                controllers="BearingResistance"},
            new ProcessModel {  name = "EC7 Bearing Resistance",
                                description ="",
                                html_page = "",
                                controllers="BearingResistance"}                    
            };
    
    }
}
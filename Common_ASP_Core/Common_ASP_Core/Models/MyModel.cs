using Microsoft.AspNetCore.Mvc;

namespace Commom_ASP_Core_Razor.Models
{
    public class MyModel
    {
        public string strText { get; set; } = "";
        public string Visible { get; set; } = "visible";
        public string Color { get; set; } = "";
        public MyModel() { }
        public MyModel(string s = "", string  V = "visible", string C = "")
        {
            strText = s;
            Visible = V;
            Color = C;
        }
    }
}
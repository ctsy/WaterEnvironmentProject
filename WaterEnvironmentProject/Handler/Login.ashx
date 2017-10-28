<%@ WebHandler Language="C#" Class="Login" %>

using System;
using System.Web;
using System.Web.Script.Serialization;

public class Login : IHttpHandler {

    public void ProcessRequest(HttpContext context)
    {
        context.Response.ContentType = "text/plain";
        string index = context.Request.Params.Get("index");
        JsonClass.Json_Login pitem = new JsonClass.Json_Login();
        Maticsoft.BLL.T_Wrong WrongBll = new Maticsoft.BLL.T_Wrong();
        Maticsoft.Model.T_Wrong wrongModel = WrongBll.GetModel(1);
        if (index == "1")
        {
            pitem.Name = wrongModel.ProblemName;
            pitem.Success = true;
        }
        else
        {
            pitem.Name = wrongModel.ProblemCode; 
            pitem.Success = false;
        }
        
        //第二种方法
        System.Data.DataSet ds = WrongBll.GetList("");
        pitem.Name = ds.Tables[0].Rows[0][2].ToString();
        //第三种方法
        System.Collections.Generic.List<Maticsoft.Model.T_Wrong> ListWrongModel = WrongBll.GetModelList("");
        pitem.Name = ListWrongModel[0].ProblemName;
        //得到数据表的数据
        Maticsoft.BLL.A_Table WrongTable = new Maticsoft.BLL.A_Table();
        System.Data.DataSet Dt = WrongTable.GetList("", "A_GF_994");
        
        context.Response.Write(new JavaScriptSerializer().Serialize(pitem));
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}
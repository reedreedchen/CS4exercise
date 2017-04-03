using System;



[AttributeUsage(AttributeTargets.Class | AttributeTargets.Delegate)]
public class remarkAttribute : Attribute{
    string pri_remark;
    public string suppliment;
    public int priority { get; set; }
    
    public remarkAttribute(string str){
        pri_remark = str;
        suppliment = "none";
        priority = 1;
    }

    public string remark
    {
        get
        {
            return pri_remark;

        }
    }

}



[remark("this is an attribute", suppliment = "this is the named parameter.", priority = 2)]
public class UseAttrib {


}
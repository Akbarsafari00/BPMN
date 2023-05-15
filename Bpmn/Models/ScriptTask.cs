/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL")]
[System.Xml.Serialization.XmlRootAttribute("scriptTask", Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL", IsNullable=false)]
public partial class ScriptTask : Task {
    
    private System.Xml.XmlNode scriptField;
    
    private string scriptFormatField;
    
    /// <remarks/>
    public System.Xml.XmlNode script {
        get {
            return this.scriptField;
        }
        set {
            this.scriptField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string scriptFormat {
        get {
            return this.scriptFormatField;
        }
        set {
            this.scriptFormatField = value;
        }
    }
}
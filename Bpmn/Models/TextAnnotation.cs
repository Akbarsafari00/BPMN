/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL")]
[System.Xml.Serialization.XmlRootAttribute("textAnnotation", Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL", IsNullable=false)]
public partial class TextAnnotation : Artifact {
    
    private System.Xml.XmlNode textField;
    
    private string textFormatField;
    
    public TextAnnotation() {
        this.textFormatField = "text/plain";
    }
    
    /// <remarks/>
    public System.Xml.XmlNode text {
        get {
            return this.textField;
        }
        set {
            this.textField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute("text/plain")]
    public string textFormat {
        get {
            return this.textFormatField;
        }
        set {
            this.textFormatField = value;
        }
    }
}
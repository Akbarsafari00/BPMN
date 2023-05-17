#nullable disable
using Bpmn.Models.Elements;
/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL")]
[System.Xml.Serialization.XmlRootAttribute("extensionElements", Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL", IsNullable=false)]
public partial class ExtensionElements {
    
    private System.Xml.XmlElement[] anyField;
    private HaniaType type;
    /// <remarks/>
    [System.Xml.Serialization.XmlAnyElementAttribute()]
    public System.Xml.XmlElement[] Any {
        get {
            return this.anyField;
        }
        set {
            this.anyField = value;
        }
    }

    /// <remarks/>
    public HaniaType Type
    {
        get
        {
            return this.type;
        }
        set
        {
            this.type = value;
        }
    }

}
/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL")]
[System.Xml.Serialization.XmlRootAttribute("choreographyTask", Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL", IsNullable=false)]
public partial class ChoreographyTask : ChoreographyActivity {
    
    private System.Xml.XmlQualifiedName[] messageFlowRefField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("messageFlowRef")]
    public System.Xml.XmlQualifiedName[] messageFlowRef {
        get {
            return this.messageFlowRefField;
        }
        set {
            this.messageFlowRefField = value;
        }
    }
}
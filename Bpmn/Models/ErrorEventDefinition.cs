/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL")]
[System.Xml.Serialization.XmlRootAttribute("errorEventDefinition", Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL", IsNullable=false)]
public partial class ErrorEventDefinition : EventDefinition {
    
    private System.Xml.XmlQualifiedName errorRefField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.Xml.XmlQualifiedName errorRef {
        get {
            return this.errorRefField;
        }
        set {
            this.errorRefField = value;
        }
    }
}
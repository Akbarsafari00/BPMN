/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL")]
[System.Xml.Serialization.XmlRootAttribute("globalChoreographyTask", Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL", IsNullable=false)]
public partial class GlobalChoreographyTask : Choreography {
    
    private System.Xml.XmlQualifiedName initiatingParticipantRefField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.Xml.XmlQualifiedName initiatingParticipantRef {
        get {
            return this.initiatingParticipantRefField;
        }
        set {
            this.initiatingParticipantRefField = value;
        }
    }
}
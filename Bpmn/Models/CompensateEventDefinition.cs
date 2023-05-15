/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL")]
[System.Xml.Serialization.XmlRootAttribute("compensateEventDefinition", Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL", IsNullable=false)]
public partial class CompensateEventDefinition : EventDefinition {
    
    private bool waitForCompletionField;
    
    private bool waitForCompletionFieldSpecified;
    
    private System.Xml.XmlQualifiedName activityRefField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool waitForCompletion {
        get {
            return this.waitForCompletionField;
        }
        set {
            this.waitForCompletionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool waitForCompletionSpecified {
        get {
            return this.waitForCompletionFieldSpecified;
        }
        set {
            this.waitForCompletionFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.Xml.XmlQualifiedName activityRef {
        get {
            return this.activityRefField;
        }
        set {
            this.activityRefField = value;
        }
    }
}
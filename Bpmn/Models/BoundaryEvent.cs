/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL")]
[System.Xml.Serialization.XmlRootAttribute("boundaryEvent", Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL", IsNullable=false)]
public partial class BoundaryEvent : CatchEvent {
    
    private bool cancelActivityField;
    
    private System.Xml.XmlQualifiedName attachedToRefField;
    
    public BoundaryEvent() {
        this.cancelActivityField = true;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(true)]
    public bool cancelActivity {
        get {
            return this.cancelActivityField;
        }
        set {
            this.cancelActivityField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.Xml.XmlQualifiedName attachedToRef {
        get {
            return this.attachedToRefField;
        }
        set {
            this.attachedToRefField = value;
        }
    }
}
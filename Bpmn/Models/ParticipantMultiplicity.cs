/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL")]
[System.Xml.Serialization.XmlRootAttribute("participantMultiplicity", Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL", IsNullable=false)]
public partial class ParticipantMultiplicity : BaseElement {
    
    private int minimumField;
    
    private int maximumField;
    
    public ParticipantMultiplicity() {
        this.minimumField = 0;
        this.maximumField = 1;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(0)]
    public int minimum {
        get {
            return this.minimumField;
        }
        set {
            this.minimumField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(1)]
    public int maximum {
        get {
            return this.maximumField;
        }
        set {
            this.maximumField = value;
        }
    }
}
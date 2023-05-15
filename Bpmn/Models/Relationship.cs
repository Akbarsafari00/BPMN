/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL")]
[System.Xml.Serialization.XmlRootAttribute("relationship", Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL", IsNullable=false)]
public partial class Relationship : BaseElement {
    
    private System.Xml.XmlQualifiedName[] sourceField;
    
    private System.Xml.XmlQualifiedName[] targetField;
    
    private string typeField;
    
    private RelationshipDirection directionField;
    
    private bool directionFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("source")]
    public System.Xml.XmlQualifiedName[] source {
        get {
            return this.sourceField;
        }
        set {
            this.sourceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("target")]
    public System.Xml.XmlQualifiedName[] target {
        get {
            return this.targetField;
        }
        set {
            this.targetField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type {
        get {
            return this.typeField;
        }
        set {
            this.typeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public RelationshipDirection direction {
        get {
            return this.directionField;
        }
        set {
            this.directionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool directionSpecified {
        get {
            return this.directionFieldSpecified;
        }
        set {
            this.directionFieldSpecified = value;
        }
    }
}
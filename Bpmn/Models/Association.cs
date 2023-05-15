/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL")]
[System.Xml.Serialization.XmlRootAttribute("association", Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL", IsNullable=false)]
public partial class Association : Artifact {
    
    private System.Xml.XmlQualifiedName sourceRefField;
    
    private System.Xml.XmlQualifiedName targetRefField;
    
    private AssociationDirection associationDirectionField;
    
    public Association() {
        this.associationDirectionField = AssociationDirection.None;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.Xml.XmlQualifiedName sourceRef {
        get {
            return this.sourceRefField;
        }
        set {
            this.sourceRefField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.Xml.XmlQualifiedName targetRef {
        get {
            return this.targetRefField;
        }
        set {
            this.targetRefField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(AssociationDirection.None)]
    public AssociationDirection associationDirection {
        get {
            return this.associationDirectionField;
        }
        set {
            this.associationDirectionField = value;
        }
    }
}
/// <remarks/>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(Performer))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(HumanPerformer))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(PotentialOwner))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL")]
[System.Xml.Serialization.XmlRootAttribute("resourceRole", Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL", IsNullable=false)]
public partial class ResourceRole : BaseElement {
    
    private object[] itemsField;
    
    private string nameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("resourceAssignmentExpression", typeof(ResourceAssignmentExpression))]
    [System.Xml.Serialization.XmlElementAttribute("resourceParameterBinding", typeof(ResourceParameterBinding))]
    [System.Xml.Serialization.XmlElementAttribute("resourceRef", typeof(System.Xml.XmlQualifiedName))]
    public object[] Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
}
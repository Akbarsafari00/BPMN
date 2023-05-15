/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL")]
[System.Xml.Serialization.XmlRootAttribute("assignment", Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL", IsNullable=false)]
public partial class Assignment : BaseElement {
    
    private Expression fromField;
    
    private Expression toField;
    
    /// <remarks/>
    public Expression from {
        get {
            return this.fromField;
        }
        set {
            this.fromField = value;
        }
    }
    
    /// <remarks/>
    public Expression to {
        get {
            return this.toField;
        }
        set {
            this.toField = value;
        }
    }
}
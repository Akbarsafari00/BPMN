#nullable disable
/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.omg.org/spec/DD/20100524/DC")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.omg.org/spec/DD/20100524/DC", IsNullable=false)]
public partial class Point {
    
    private double xField;
    
    private double yField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public double x {
        get {
            return this.xField;
        }
        set {
            this.xField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public double y {
        get {
            return this.yField;
        }
        set {
            this.yField = value;
        }
    }
}
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Bpmn;
using Bpmn.Extensions;

var instance = new Instance("diagram.bpmn");


var processes = instance.AllProcess();

foreach (var process in processes)
{
    var start = process.FirstStartEvent();


    if (start == null) throw new ArgumentNullException(nameof(start));
    foreach (var element in start.extensionElements.Any)
    {
        for (int nodeIndex = 0; nodeIndex < element.ChildNodes.Count; nodeIndex++)
        {
            var item = element.ChildNodes[nodeIndex];
            for (int attributeIndex = 0; attributeIndex < item.Attributes.Count; attributeIndex++)
            {
                Console.WriteLine(item.Attributes[attributeIndex].InnerText);
            }
        }
        
    }
    Console.WriteLine(start.id);

}







using System.Text;
using System.Xml.Serialization;
using Bpmn.Extensions;

var inputString = File.ReadAllText("C:\\Users\\isar\\source\\repos\\BPMN\\Bpmn.Console\\diagram.bpmn");
var serializer = new XmlSerializer(typeof(Definitions));
var memStream = new MemoryStream(Encoding.UTF8.GetBytes(inputString));

var definitions = (Definitions)serializer.Deserialize(memStream)!;

var process = definitions.FirstProcess();

var startEvent = process.FirstStartEvent();

var next = process.NextElement(startEvent);


Console.WriteLine(definitions);
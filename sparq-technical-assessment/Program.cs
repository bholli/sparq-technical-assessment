
using sparq_technical_assessment;

//code assumes TVlalue is string

Console.WriteLine("welcome to the sparq technical assessment");

StringMap<string> map = new StringMap<string>();

//default value
map.DefaultValue = "default";

//write default value
Console.WriteLine("Default value: " + map.DefaultValue);

//add element
map.AddElement("something", "good");

//write value of key == "something"
Console.WriteLine(map.GetValue("something"));

//write value of key == "something else"
Console.WriteLine(map.GetValue("something else"));

//count; should == 1
Console.WriteLine("Count: " + map.Count);

//add element
map.AddElement("everything", "good");

//count should == 2
Console.WriteLine("Count: " + map.Count);

//remove element
map.RemoveElement("something");

//count; should == 1
Console.WriteLine("Count: " + map.Count);

//EXCEPTION: attempt to add element with null key; should throw exception
map.AddElement(null, "boom");

//EXCEPTION: attempt to add element with empty key; should throw exception
map.AddElement("", "boom");

//EXCEPTION: attempt to add element with duplicate key; should throw exception
map.AddElement("something", "bad");

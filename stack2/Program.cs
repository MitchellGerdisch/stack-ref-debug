using System.Collections.Generic;
using Pulumi;

return await Deployment.RunAsync(() =>
{
   // Add your resources here
   // e.g. var resource = new Resource("name", new ResourceArgs { });
   var other = new StackReference("MitchGerdisch/stack1/dev");
   var otherOutput = other.GetOutput("username");

   // Export outputs here
   return new Dictionary<string, object?>
   {
      ["inputfromstack1"] = otherOutput
   };
});

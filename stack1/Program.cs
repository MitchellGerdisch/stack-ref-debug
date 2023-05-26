using System.Collections.Generic;
using Pulumi;
using Pulumi.Random;


return await Deployment.RunAsync(() =>
{
   // Add your resources here
   // e.g. var resource = new Resource("name", new ResourceArgs { });
   var username = new RandomPet("my-user-name", new RandomPetArgs{});


   // Export outputs here
   return new Dictionary<string, object?>
   {
      ["username"] = username.Id
   };
});

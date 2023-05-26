# stack-ref-debug
This is a temporary repo to debug an issue.

# Test sequence

## Preparation
- stack1 and stack2 .csproj set up with `<PackageReference Include="Pulumi" Version="3.2.1" />`


## Steps
- run `install_pulumi.sh --version 3.19.0`
- Modify stack2/Program.cs to reference the stack1 stack in your environment.
- cd stack1 and launch stack1
  - `pulumi up -y`
- cd ../stack2 and launch stack2
  - `pulumi up -y`
  - stack2 output should represent the output read from stack1
- cd ../stack1
- Modify stack1.csproj to get pulumi package 3.3.0
  - `<PackageReference Include="Pulumi" Version="3.3.0" />`
- `dotnet list package`
  - To ensure stack1 is now using pulumi CLI version 3.3.0 
- `pulumi up -y`
  - Update stack1
- cd ../stack2
- `pulumi up`
  - **AS PER CUSTOMER** this should hang if replicating the problem.
  - **HOWEVER** it does not appear to be happening ....

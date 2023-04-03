$ScriptDir = Split-Path $script:MyInvocation.MyCommand.Path
$GeneratedClientDir = Resolve-Path "$ScriptDir/../Implementations"
$GeneratedClientFilePath = "$GeneratedClientDir/GeneratedForecastClient.cs"
$Namespace = "LearnDotNet.WebAppSample.Client.Generated.Implementations"

if (Test-Path $GeneratedClientFilePath) {
  Remove-Item $GeneratedClientFilePath
}

nswag openapi2csclient /parameterDateTimeFormat:"O" /input:$ScriptDir/swagger.json `
    /namespace:$Namespace /output:$GeneratedClientFilePath `
    /generateClientInterfaces:true /generateClientClasses:true  `
    /OperationGenerationMode:MultipleClientsFromFirstTagAndOperationId `
    /ClientClassAccessModifier:internal `
    /GenerateNullableReferenceTypes:true
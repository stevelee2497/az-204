using System.Threading.Tasks;
using Microsoft.Identity.Client;

const string _clientId = "468e8097-c0fa-4a3f-afdc-f1ce8d1742fa";
const string _tenantId = "887ae08b-33e7-4a86-a59e-ef30765fb606";

var app = PublicClientApplicationBuilder
  .Create(_clientId)
  .WithAuthority(AzureCloudInstance.AzurePublic, _tenantId)
  .WithRedirectUri("http://localhost")
  .Build();

string[] scopes = { "user.read" };

AuthenticationResult result = await app.AcquireTokenInteractive(scopes).ExecuteAsync();

Console.WriteLine($"Token:\t{result.AccessToken}");
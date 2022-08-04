<h1>CircitChallenge</h1>
<p>A single page application built with Vue.js and .NET Core Web API displaying different cities' weather & other info. This was created for my job application for Circit. </p>

![example workflow](https://github.com/ryandeering/CircitChallenge/actions/workflows/CircitChallengeAPI.yml/badge.svg)

<img src="https://github.com/ryandeering/circitchallenge/blob/main/docs/demo.gif" alt="Demo gif" title="Demo gif" width="800"/>

<h1>Online Links</h1>

https://genuine-beignet-f03e44.netlify.app/ - Frontend deployed on Netlify.

https://circitchallengeapi.azurewebsites.net/api/ - API hosted on Azure App Service, needs a warmup request to start.

<h1>Technologies & Features</h1>

* Vue.js CLI [requires a version of Node.js version 15.0 or higher]
* .NET Core Web API [requires .NET 6]
* CI/CD pipeline for backend API
* Unit and Integration testing with Moq and xUnit

<h1>Building Locally</h1>

To build the project, run the following commands in the root folder of the repo:

> dotnet restore

> dotnet build

<h1>Running Locally - Backend</h1>

To run the backend, from the root folder navigate to CircitChallenge.API.

Open the command prompt and run the following command:

> dotnet run

If successful, you should see a prompt that the API has been built and running on ports 5001 and 5003 respectively.

<h1>Running Locally - Frontend</h1>

To run the frontend, from the root folder navigate to CircitChallenge.Frontend:

Open the command prompt and run the following command:

> npm run serve

If successful, you should see a prompt that the frontend has been built and running on port 7094.

Feel free to navigate to https://localhost:7094/ and you should see data pour in similar to the gif on this README.md.


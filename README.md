<h1>CircitChallenge</h1>
<p>A single page application built with Vue.js and .NET Core Web API displaying different cities' weather & other info. </p>

![example workflow](https://github.com/ryandeering/CircitChallenge/actions/workflows/CircitChallengeAPI.yml/badge.svg)

<img src="https://github.com/ryandeering/albumtrackr/blob/main/docs/demo.gif" alt="Demo gif" title="Demo gif" width="400"/>

<h1>Online Links</h1>

https://genuine-beignet-f03e44.netlify.app/ - Frontend deployed on Netlify.

https://circitchallengeapi.azurewebsites.net/api/ - API hosted on Azure App Service, needs a warmup request to start.

<h1>Technologies & Features</h1>

* Vue.js CLI [requires a version of Node.js version 15.0 or higher]
* .NET Core Web API [requires .NET 6]
* CI/CD pipeline for backend API
* Unit and Integration testing with Moq and xUnit

<h1>Running Locally - Backend</h1>

To build and run the backend, go to the root folder when cloned and open a command prompt in the CircitChallenge.API folder:

Run the following commands in this order.

>dotnet restore

>dotnet build

>dotnet run

If successful, you should see a prompt that the API has been built and running on ports 7094 and 5094 respectively.

<h1>Running Locally - Frontend</h1>

To build and run the frontend, go to the root folder when cloned and open a command prompt in the CircitChallenge.Frontend folder:

Run the following commands in this order.

>npm install

>npm run serve

If successful, you should see a prompt that the frontend has been built and running on ports 5002.

Feel free to navigate to https://localhost:5002/ and you should see data pour in similar to the gif on this README.md.


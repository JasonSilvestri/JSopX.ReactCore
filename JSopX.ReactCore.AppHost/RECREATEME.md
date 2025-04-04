# <img src="https://github.com/JasonSilvestri/JSopX.BridgeTooFar/blob/master/JSopX.BridgeTooFar/doc-assets/jsopx-react-core-logo.svg" style="width: 28px; height: auto; padding-right:12px;!important;"> JSopX™ React Core Project

The **JSopX™ React Core Project**, _code named_, `JSopX.ReactCore` is a totally **FREE**, open-source, demonstration project showcasing how to build a web application using Angular and ASP.NET Core Web API. 

---

## **Start From Scratch Variant:**

> [!TIP]
> You are currently viewing the **"_Start From Scratch_" _Variant_** of the **JSopX™ React Core Project**. 
> 
> For more details, see [Getting Started](#getting-started) _below_.

---


```bash
# For The Cool Kids: Clone JSopX.ReactCore Git Repository
$ git clone https://github.com/JasonSilvestri/JSopX.ReactCore.git
```

---

[`Home`](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.ReactCore/p1/v1/README.md) » [`Introduction`](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/Introduction/) » [`Projects`](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.ReactCore/p1/v1/OpenProjects/) · · [`Use Latest`](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.ReactCore/README.md) · [`By-Phase`](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.ReactCore/p1/v1/README.md) · **`From Scratch`** · · [`« Previous`](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.AngularCore/p1/v1/RECREATEME.md) [`Next »`](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.VueCore/p1/v1/RECREATEME.md)

---

  
## Table of Contents

  - [Overview](#overview)
  - [Prerequisites](#prerequisites)
  - [Getting Started](#getting-started)
      - [Step 1: Recreate Using React and ASP.NET Core Template](#step-1-recreate-jsopxreactcore-using-react--aspnet-core-template)
      - [Step 2: Extend Weather Data](#step-2-extend-weather-data)
      - [Step 3: Integrate OIDC](#step-3-integrate-oidc)
      - [Step 4: Decouple from Built-In API](#step-4-decouple-from-built-in-api)
      - [Step 5: Standardize with RCLs and Libraries](#step-5-standardize-with-rcls-and-libraries)
  - [Next Steps](#next-steps)
  
---

## Current Phase

> [!IMPORTANT]
>
>**Phases 1**: This document is currently aligned with [Phase 1: Minimum Viable Product (MVP)](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/Phases/Phase-1.md) Business Requirements. 
> 

---

> [!CAUTION]
> **This is a DRAFT:**
> 
> The content before you is a draft version of the document. It **should not** be considered **accurate** and may contain placeholder information.

---

## Overview

The **JSopX™ React Core Project**, _code named_, `JSopX.ReactCore` is a totally **FREE**, open-source, demonstration project showcasing how to build a web application using Angular and ASP.NET Core Web API. As a whole, the project highlights the integration of _Angular_ for the client-side with _ASP.NET Core_ for the server-side, providing a comprehensive example of a modern web application stack. Conversely, the project has a much higher calling.

It's one of over a dozen epic projects from the Jason Silvestri Open Project EXperiences (JSopX™) Collection, with its own _code name_, `JSopX.OpenProjectX`—a multi-platform, multi-stack, all-in-one enterprise application, featuring projects in [React](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.ReactCore/README.md), [Vue](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.VueCore/README.md), [Vue](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.VueCore/README.md), [Asp.NET Core](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.AspNetCore/README.md), [Blazor](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.BlazorServerCore/README.md), [MAUI](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.MauiHybridNetCore/README.md) and more, all using the same [Web API](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.WebAPI/README.md), [assets](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.RCLxProper/README.md), [documentation](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.BridgeTooFar/README.md), and [standards](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/Introduction/JSopxDisciplinesRequiredForEnterpriseDevelopment.md).

We initially create the project to simulate an ["Existing" Client-side Apps Example](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/Introduction/JSopxProjectsFamilies.md#5-client-side-existing-apps-examples) Weather Forecast Angular application, with its own Web API and existing standards, to conform to the initial [business requirements](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/Introduction/JSopxEnterpriseBusinessRequirements.md) set forth by the fictional stakeholders.

As the project evolves through each [Lifecycle Phase](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/Phases/ReadMe.md), we extend the application by creating new user interfaces, the integratation of standardized assets and resources commonly used across projects that comply to the stakeholder's brand standards we are tasked with creating, perform typical increase of security and documentation, while anticipating we'll face a near-future, seamless migration request of the project into our [JSopX.OpenProjectX](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.OpenProjectX/) Enterprise Application.

The Jason Silvestri Open Project EXperiences (JSopX™) Visual Studio Projects collectively form the backbone of the entire suite, each project serving a distinct yet complementary role. 

By aligning varied frameworks—ranging from [ASP.NET Core](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.AspNetCore/README.md) to [Angular](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.AngularCore/README.md), [Vue](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.VueCore/README.md), [React](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.ReactCore/README.md), [Blazor](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.BlazorServerCore/README.md), [MAUI](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.MauiHybridNetCore/README.md) and more, all using the same [Web API](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.WebAPI/README.md), [assets](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.RCLxProper/README.md), [documentation](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.BridgeTooFar/README.md), and [standards](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/Introduction/JSopxDisciplinesRequiredForEnterpriseDevelopment.md)—these projects create a consistent development landscape where code can be shared, extended, and integrated seamlessly.

The result is an environment that transforms a patchwork of independent solutions into a cohesive enterprise ecosystem, making collaboration smoother and long-term maintenance more manageable. As you delve deeper, you’ll discover how each project type fits into this grand tapestry, ensuring uniform standards while preserving the flexibility needed to evolve and adapt.

[`Back to Top`](#table-of-contents)

---

## **Prerequisites**

Be sure each technology is installed, with proper versioning, if your goal is to continue exploring and/or installing just the `JSopX.ReactCore` Project.

- [Visual Studio (v 17.13.5)](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.ReactCore/p1/v1/Technologies/#visual-studio)
- [.NET Framework (v 9.0.1)](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.ReactCore/p1/v1/Technologies/#net-framework)
- [ASP.NET Core (v 9.0.1)](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.ReactCore/p1/v1/Technologies/#aspnet-core)
- [Node.js (v 20.14.0)](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.ReactCore/p1/v1/Technologies/#node)
- [npm (v 10.8.1)](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.ReactCore/p1/v1/Technologies/#npm)
- [React (v 18.2.0)](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.ReactCore/p1/v1/Technologies/#react)

---

## **Getting Started**

Carefully _choose_ the variant approach below that fits your current objective:

---

### 1. **Continue Creating `JSopX.`ReactCore From Scratch**:

- **[Continue](#step-1-recreate-jsopxreactcore-using-react--aspnet-core-template)** → **Continue** as **you were**, **creating projects** from scratch, step-by-step, using the `JSopX.ReactCore` _From Scratch_ Variant.   

---

### 2. **Use Different Variant**:

- **[Install Using Latest](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.ReactCore/README.md)** → **Install** or **explore** the latest version of **this project**, using the `JSopX.ReactCore` _Using Latest_ Variant.  
- **[Browse By-Phase](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.ReactCore/p1/v1/README.md)** → **Browse** **previous versions** of the application by **phases** using the `JSopX.ReactCore` _By-Phase_ Variant.   
- **[Get All Projects](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.OpenProjectX/README.md)** → **Get all projects** instead, using the `JSopX.OpenProjectX` Enterprise Application.

---

## **Step 1: Recreate `JSopX.`ReactCore Using Angular & ASP.NET Core Template**


**Goal**: Simulate an existing React app with weather data, Identity, and JWT already established.

1. **Open Visual Studio 2022 (v 17.13.5)**:
   - Ensure .NET 9.0 SDK, Node 20.14.0, and npm 10.8.1 are installed (React 18.2.0 comes with template).

2. **Create the Project**:
   - File > New > Project.
   - Search for “ASP.NET Core with React”.
   - Configure:
     - Project Name: `JSopX.ReactCore`.
     - Location: e.g., `path\to\local\repo\JasonSilvestri\JSopX.ReactCore`.
     - Solution Name: `JSopX.ReactCore`.
     - .NET Framework (v 9.0.1)
   - Click Create.

3. **Set Up Initial Weather Data**:
   - In `JSopX.ReactCore/jsopx.reactcore.client/src/components/FetchData.js`:

     ```javascript
     import React, { useEffect, useState } from 'react';
     export const FetchData = () => {
       const [forecasts, setForecasts] = useState([]);
       useEffect(() => {
         fetch('weatherforecast')
           .then(response => response.json())
           .then(data => setForecasts(data));
       }, []);
       return (
         <div>
           <h1>JSopX™ Weather</h1>
           <table>
             <thead><tr><th>Date</th><th>Temp (°C)</th><th>Summary</th></tr></thead>
             <tbody>
               {forecasts.map(forecast => (
                 <tr key={forecast.date}>
                   <td>{new Date(forecast.date).toLocaleDateString()}</td>
                   <td>{forecast.temperatureC}</td>
                   <td>{forecast.summary}</td>
                 </tr>
               ))}
             </tbody>
           </table>
         </div>
       );
     };
     ```
   - Keep `JSopX.ReactCore/JSopX.ReactCore.Server/Controllers/WeatherForecastController.cs` as default.

4. **Add Identity + JWT (Simulating Existing Setup)**:
   - Install NuGet: `Microsoft.AspNetCore.Authentication.JwtBearer`.
   - Update `Program.cs`:

     ```csharp
     builder.Services.AddAuthentication()
         .AddJwtBearer(options =>
         {
             options.TokenValidationParameters = new TokenValidationParameters
             {
                 ValidateIssuer = true,
                 ValidateAudience = true,
                 ValidateLifetime = true,
                 ValidateIssuerSigningKey = true,
                 ValidIssuer = builder.Configuration["Jwt:Issuer"],
                 ValidAudience = builder.Configuration["Jwt:Audience"],
                 IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
             };
         });
     builder.Services.AddSpaStaticFiles(configuration => configuration.RootPath = "JSopX.ReactCore/jsopx.reactcore.client/build");
     var app = builder.Build();
     app.UseAuthentication();
     app.UseAuthorization();
     app.UseSpa(spa => spa.Options.SourcePath = "ClientApp");
     ```
   - Update `appsettings.json`:

     ```json
     {
       "Jwt": { "Key": "8f+2Kj9mPqL5xRtYvWnZcQwXjB3sM7hD9pN8uG4tA1o=", "Issuer": "JSopX", "Audience": "JSopX" }
     }
     ```
   - Add `JSopX.ReactCore/JSopX.ReactCore.Server/Controllers/AuthController.cs`:

     ```csharp
     [Route("api/[controller]")]
     [ApiController]
     public class AuthController : ControllerBase
     {
         private readonly IConfiguration _config;
         public AuthController(IConfiguration config) => _config = config;
         [HttpPost("login")]
         public IActionResult Login([FromBody] LoginModel model)
         {
             if (model.Username == "test" && model.Password == "password") // Dummy check
             {
                 var token = GenerateJwtToken(model.Username);
                 return Ok(new { token });
             }
             return Unauthorized();
         }
         private string GenerateJwtToken(string username)
         {
             var claims = new[] { new Claim(ClaimTypes.Name, username) };
             var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
             var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
             var token = new JwtSecurityToken(_config["Jwt:Issuer"], _config["Jwt:Audience"], claims, expires: DateTime.Now.AddMinutes(30), signingCredentials: creds);
             return new JwtSecurityTokenHandler().WriteToken(token);
         }
     }
     public class LoginModel { public string Username { get; set; } public string Password { get; set; } }
     ```
   - Add `JSopX.ReactCore/jsopx.reactcore.client/src/components/Login.js`:

     ```javascript
     import React, { useState } from 'react';
     export const Login = () => {
       const [username, setUsername] = useState('');
       const [password, setPassword] = useState('');
       const [message, setMessage] = useState('');
       const login = () => {
         fetch('/api/auth/login', {
           method: 'POST',
           headers: { 'Content-Type': 'application/json' },
           body: JSON.stringify({ username, password })
         })
           .then(response => response.json())
           .then(data => {
             localStorage.setItem('jwt', data.token);
             setMessage('Logged in!');
           })
           .catch(() => setMessage('Login failed'));
       };
       return (
         <div>
           <input value={username} onChange={e => setUsername(e.target.value)} placeholder="Username" />
           <input type="password" value={password} onChange={e => setPassword(e.target.value)} placeholder="Password" />
           <button onClick={login}>Login</button>
           <p>{message}</p>
         </div>
       );
     };
     ```
   - Update `JSopX.ReactCore/jsopx.reactcore.client/src/App.js`:

     ```javascript
     import { Login } from './components/Login';
     const App = () => (
       <Router>
         <Routes>
           <Route path="/" element={<Home />} />
           <Route path="/fetch-data" element={<FetchData />} />
           <Route path="/login" element={<Login />} />
         </Routes>
       </Router>
     );
     ```

5. **Test the Base Setup**:
   - Run `npm install` in `JSopX.ReactCore/jsopx.reactcore.client/`.
   - Start the app (`F5`).
   - Go to `/login`, use `test/password`, then `/fetch-data`.


[`Back to Top`](#table-of-contents)

---

## Step 2: Extend Weather Data

**Goal**: Add historical weather data.

1. **Update Weather Model**:
   - In `FetchData.js`, expect `historicalTempC`:

     ```javascript
     // Implicit in the fetch response
     ```

2. **Update Weather Controller**:
   - In `WeatherForecastController.cs`:

     ```csharp
     [Authorize]
     [HttpGet]
     public IEnumerable<WeatherForecast> Get()
     {
         return Enumerable.Range(1, 5).Select(index => new WeatherForecast
         {
             Date = DateTime.Now.AddDays(index),
             TemperatureC = Random.Shared.Next(-20, 55),
             Summary = Summaries[Random.Shared.Next(Summaries.Length)],
             HistoricalTempC = Random.Shared.Next(-25, 50)
         });
     }
     ```

3. **Update Fetch Data Component**:
   - In `FetchData.js`:

     ```javascript
     <thead><tr><th>Date</th><th>Temp (°C)</th><th>Historical Temp (°C)</th><th>Summary</th></tr></thead>
     <td>{forecast.historicalTempC}</td>
     ```

4. **Test**: Reload `/fetch-data` and verify historical data.


[`Back to Top`](#table-of-contents)

---

## Step 3: Integrate OIDC

**Goal**: Use OIDC via `JSopX.AspNetCore`’s IdentityServer.

1. **Install React OIDC Client**:
   - In `JSopX.ReactCore/jsopx.reactcore.client/`: `npm install oidc-client-ts`.

2. **Configure OIDC**:
   - Add `JSopX.ReactCore/jsopx.reactcore.client/src/auth.js`:

     ```javascript
     import { UserManager } from 'oidc-client-ts';
     export const userManager = new UserManager({
       authority: 'https://localhost:7235',
       client_id: 'react',
       redirect_uri: window.location.origin + '/callback',
       scope: 'openid profile api',
       response_type: 'code',
       silentRenew: true
     });
     ```
   - Add `JSopX.ReactCore/jsopx.reactcore.client/src/components/Callback.js`:

     ```javascript
     import { useEffect } from 'react';
     import { userManager } from '../auth';
     export const Callback = () => {
       useEffect(() => { userManager.signinRedirectCallback().then(() => window.location = '/'); }, []);
       return <div>Logging in...</div>;
     };
     ```
   - Update `App.js`:

     ```javascript
     import { userManager } from './auth';
     import { Callback } from './components/Callback';
     const App = () => {
       useEffect(() => { userManager.getUser().then(user => console.log(user)); }, []);
       return (
         <Router>
           <Routes>
             <Route path="/callback" element={<Callback />} />
             ...
           </Routes>
         </Router>
       );
     };
     ```

3. **Secure API Calls**:
   - In `FetchData.js`:

     ```javascript
     useEffect(() => {
       userManager.getUser().then(user => {
         fetch('weatherforecast', {
           headers: { 'Authorization': `Bearer ${user.access_token}` }
         })
           .then(response => response.json())
           .then(data => setForecasts(data));
       });
     }, []);
     ```

4. **Test**: Add `react` client to `Config.cs` in `JSopX.AspNetCore`, log in, verify `/fetch-data`.


[`Back to Top`](#table-of-contents)

---

## Step 4: Decouple from Built-In API

**Goal**: Use `JSopX.WebAPI`.

1. **Update Fetch Data**:
   - In `FetchData.js`:

     ```javascript
     fetch('https://localhost:7234/api/weather', { headers: { 'Authorization': `Bearer ${user.access_token}` } })
     ```

2. **Test**: Ensure data comes from `JSopX.WebAPI`.


[`Back to Top`](#table-of-contents)

---

## Step 5: Standardize with RCLs and Libraries

1. **Reference JSopX.RCLxProper**:
   - Mimic style in `FetchData.css`:

     ```css
     table { border-collapse: collapse; }
     th, td { border: 1px solid #ddd; padding: 8px; }
     ```

2. **Reference JSopX.SharedResources**:
   - Add `JSopX.ReactCore/jsopx.reactcore.client/src/weatherUtils.js`:

     ```javascript
     export const getWeatherIcon = summary => summary === 'Cool' ? '❄️' : summary === 'Warm' ? '☀️' : '🔥';
     ```
   - Use in `FetchData.js`:

     ```javascript
     import { getWeatherIcon } from '../weatherUtils';
     <td>{getWeatherIcon(forecast.summary)}</td>
     ```

3. **Test**: Verify icons appear.

[`Back to Top`](#table-of-contents)

---

## **Next Steps**

Carefully choose the approach below that fits your current objective:

---

1. **[Continue](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.VueCore/p1/v1/RECREATEME.md)** → **Continue** as **you were**, **creating projects** from scratch, step-by-step. You'll move onto the next project, using the `JSopX.VueCore` _From Scratch_ Variant.   

---

1. **[Install Using Latest](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.ReactCore/README.md)** → **Install** or **explore** the latest version of **this project**, using the `JSopX.ReactCore` _Using Latest_ Variant.  
2. **[Browse By-Phase](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.ReactCore/p1/v1/README.md)** → **Browse** **previous versions** of the application by **phases** using the `JSopX.ReactCore` _By-Phase_ Variant.   
3. **[Get All Projects](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.OpenProjectX/README.md)** → **Get all projects** instead, using the `JSopX.OpenProjectX` Enterprise Application.

---

[`Home`](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.ReactCore/p1/v1/README.md) » [`Introduction`](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/Introduction/) » [`Projects`](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.ReactCore/p1/v1/OpenProjects/) · · [`Use Latest`](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.ReactCore/README.md) · [`By-Phase`](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.ReactCore/p1/v1/README.md) · **`From Scratch`** · · [`Back to Top`](#table-of-contents) · [`« Previous`](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.AngularCore/p1/v1/RECREATEME.md) [`Next »`](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.VueCore/p1/v1/RECREATEME.md)

---

##### [JSopX.com](https://www.jsopx.com/) | [Jason's Official Website](https://www.jsilvestri.com/) | [X](https://www.x.com/JasonSilvestri) | [LinkedIn](http://www.linkedin.com/in/JasonSilvestri) | [GitHub](https://github.com/JasonSilvestri) | [Gmail](mailto:therealjasonsilvestri@gmail.com) | [Phone : 508-851-9445](phoneto:508-851-9445)

###### Copyright © 2025 - All Rights Reserved by Jason Silvestri

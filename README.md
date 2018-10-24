# CrowdFundingApp
A basic crown funding app demonstrating as a POC.

<h2>Prerequisites</h2>
<ul>
<li>Dot Net Core 2.1</li>
<li>Visual Studio 2017</li>
<li>Node.js</li>
</ul>

Download and open the solution, restore Nuget packages and npm packages respectively. Build and run.

<h2>Remarks</h2>
  Welcome to the Crowd Funding opportunity example. This is a Proof Of Concept (POC) demonstrating how a crowd funding application could function.
  
  <h3>Visual Studio Task List</h3>
  Using the <strong>Task List</strong> window, comments are displayed showing what code needs updating if the POC were to move forward into  a live project. To view the Task List window, <em>Menu > View > Task List</em>

<h3>Functionality</h3>
  Functionality is mostly in a mock state including an in-memory DB instance.  It is expected that this POC would evolve to include the following:
  <ul>
  <li>N-layered Solution Design;</li>
  <li>Data Access Logic (repositories, MongoDb or relationational DB context);</li>
  <li>Business Service Logic;</li>
  <li>User Authentication Logic (registration, login etc...);</li>
  <li>Unit Tests.</li>
  </ul>

<h2>User Session</h2>
  A unique Id is created for each page request to represent an <b>active user</b>;
  Persistent user investment logic is not implemented and should be added going forward based on requirements.
  
  <strong>Closing/refreshing the app window generates a new unique Id value.</strong>

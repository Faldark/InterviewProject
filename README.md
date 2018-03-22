# InterviewProject

We need an API which provide carepro registration services. We call this as carepro onboarding process. 
API should be built using REST principles and needs to use Microsoft technologies such as;
- asp.net core
- entity framework
- web api
- individual authentication
The Onboarding process has multiple steps. API needs to provide both GET and POST operations for each step. These operations (services) can be consumed as both sequential and separated.
Please consider some basic rules below;
- Only authenticated users will have an access to consume these endpoints
- JSON data will be provided from endpoints
- N Layer solution structure (like data, business and presentation)
- DDD and TDD
You can use fictional models as entities. Also, you can take advantage from written model names below.
Onboarding Steps:
1. Personal Information
2. About me
3. Pricing
4. Schedule
5. Work abilities

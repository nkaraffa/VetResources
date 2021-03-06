# Veteran Resources
A veterans resource website I made using the MVC software design pattern
___________________

## Project Statement

          - Create an interactive veterans resource website using the MVC (Model-View-Controller) software design pattern

___________________
## Versions

	  - v1:  Basic website layout, DB Filled & Linked, Models Created, Views Created, Controllers Created, 
	  	 DB Forwarding logic, 2/3 Views linked to Models, Images loaded
	  - v2:  Created a User feedback controller, created User feedback menu, linked User Feedback to DB, 
	  	 Created post-feedback submission view, content added, UI beautification
	  - v3:  Content Added, UI beautification, added functional URLs to resources
	  
	  	- Website Functional (v3) and ready for use
	  
	  - v4:  Content added, UI beautification, Added new views
	  - v5:  "PLANNED: Add search feature for data"
	  	 "PLANNED: Add Login features, admin access will allow admin to modify resource info from the webpage, admin can view all feedback"
	  

____________________
## Project Proposal

	Problem Statement:  Create an interactive veterans resource website

	Database use : SQL (VS-MASTER\SQLEXPRESS)
		• Resource contact info
			○ Resource ID, Resource Name, Website, Contact Info, Address
		• User Feedback

	Brief Description: 
		The interactive veterans resource website will have tabs for specific resources. 
		The resource tabs will cover general uses and contact information for the listed veterans resources. 
		I will include a feedback page that will enable users to provide feedback on the website as well!

	Proposed Workflow: 
		1. DB first…tables(models)
		2. Actions...controllers
		3. Views
		4. Repository (classes/services)…DB handling
		5. Dependency injection
		6. Call Methods
		7. Link them to views
		8. Styling (bootstrap)

		Enhancements:
			1. Login (Admin Access)
			2. State Management
			3. Web APIs

	Plan:
	Veterans Resource Website: 
		1. Resource Tabs - Veteran Resources & Contact Info
			1. Display resource logo
			2. Display contact information
			3. Display short synopsis of the resource

			○ Resources:  VA, Veterati, sitreps2steercos.com, VSOs, MSSA
				§ "I plan to add more as time goes on."

		2. Feedback Tab - Users can send feedback to DB
			1. Feedback Type combo-box (Error, Recommendation, Style)
			2. User Name
			3. User email
			4. Comment box for more details



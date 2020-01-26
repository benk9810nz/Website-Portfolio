# Portfolio Website

## Introduction
Over the 2019-2020 Summer Break I decided that my Summer Project would be to create an ASPNet.Core MVC Portfolio Website to showcase my work and talent.

## Timeline

### Site Layout & Key Messages
I first started planning my website in my last week of SIT in 2019, 4th-10th November. During this week I wrote down what key Messages I wanted to Showcase on my website, as well as creating the Initial Site Map of the website as seen in the below Image.

![Image of Site Map](https://benking.co.nz/Images/PortfolioStite/SiteMap.png)

### Hosting & Domains
After deciding that my website will have these 4 Pages, I then investigated Hosting and Domain Services Options first.

Initially I considered Self-Hosting my website on a Raspberry Pi using the compiled ARM Executible File of the Website, and then using nginx to reverse the Proxy allowing people to tunnel into the website using the domain. However, I decided against using this due to how the network my Raspberry Pi is connected to is on a Dynamic IP Address, meaning that I would need to either obtain a Static IP Address or using a Dynamic DNS Provider such as **No IP**.

I also decided against this due to how it would mean that my website would not have much DNS Protection opposed to an actual Company, so I then signed up for a 3 Month Trial of a Linux Hosting Subscription with OpenHost (A New Zealand Based Hosting Provider). However, I ended up cancelling this due to how OpenHost restricted my website to a Static HTML (or PhP) Website or requiring me to use WordPress to create my website. Because of how I wanted to use ASPNet.Core MVC for my website, this would not suit my requirements.

I then did some reasearch and found that as a Student Studying at Higher Education (Polytechnic/University) I could receive a 12 Months Free Subscription to several parts of a Microsoft Azure Subscription, such as the App Services Feature which would host my ASPNet.Core MVC Website. Due to how this would be hosted on Microsoft Azure, a reliable hosting Provider, I decided to go with this approach due to how I could then route My Domain to the IP Address (by setting the A Record) of the App Service.

After deciding on this, I then needed to decide on and purchase a Domain. It seemed obvious to me that if it was possible, I wanted the Domain **benking.co.nz** with how it was my name and would make	it easy to remember for people that wanted to look at my website. A quick search showed that it was available, so I then just needed to decide on a Domain Provider. Unfortunately, there are a lot of Domain Providers available, so I ended up going with Octopoly, a New Zealand Company due to how I had previously brought a domain, and if they didn't fit my needs I could always transfer my domain to another Provider 90 days after purchasing my Domain.

#### SSL Certificate
There was the option to purchase an SSL Certificate for my website when I purchased the Domain. After some careful consideration I decided to purchase one with how the certificate was not expensive, it allowed me to possibly add further features to my website that would require a more secure connection, and it would also prevent **Not Secure Website** Messages from appearing on my website, helping to reassure visitors and making it easier to visit with how Chrome and other Web Browsers would not display these Messages.

### Designing/Wireframing of the Website
After purchasing my Domain, I was then ready to start to design and create Wireframes for my website. At this point it was the end of November due to how I had been at Work (Countdown) a lot, so I hadn't had a lot of spare time to work on my website.

Such I had a clear idea of what content and information I wanted to showcase on my website, it was time to create some Wireframes allowing me to get an idea of what my Website would look like. When developing the below Wireframes I knew that I wanted to use the Bootstrap HTML Front-End Framework with how this provided many great design features that would help to make it stand out, so I also looked at Bootstrap Example Websites to get some Ideas.

#### Initial Wireframes
Home Page
![Image of Draft Wireframe Home Page](https://benking.co.nz/Images/PortfolioSite/Initial/WF1.png)
About Page
![Image of Draft Wireframe About Page](https://benking.co.nz/Images/PortfolioSite/Initial/WF2.png)
Resume Page
![Image of Draft Wireframe Resume Page](https://benking.co.nz/Images/PortfolioSite/Initial/WF3.png)
Portfolio Page
![Image of Draft Wireframe Portfolio Page](https://benking.co.nz/Images/PortfolioSite/Initial/WF4.png)
Contact Page
![Image of Draft Wireframe Contact Page](https://benking.co.nz/Images/PortfolioSite/Initial/WF5.png)

#### Final Wireframes
After designing these wireframes, I showed them to several friends and colleagues from work, getting Feedback and then redesigning them to the Below, Final Wireframes which I used to create my website:

![Image of Final Wireframe Home Page](https://benking.co.nz/Images/PortfolioSite/Final/WF1.png)
![Image of Final Wireframe About Page](https://benking.co.nz/Images/PortfolioSite/Final/WF2.png)
![Image of Final Wireframe Resume Page](https://benking.co.nz/Images/PortfolioSite/Final/WF3.png)
![Image of Final Wireframe Portfolio Page](https://benking.co.nz/Images/PortfolioSite/Final/WF4.png)
![Image of Final Wireframe Contact Page](https://benking.co.nz/Images/PortfolioSite/Final/WF5.png)

By now it was the week before Christmas so in order to ensure I had a break over the holiday period, I decided to leave this project for a couple of weeks and resuming it after the 10th of January.

### Front-End and Back-End Coding
With Christmas and the New Year all over and done with it was time to start coding and making my Website come to reality.I started coding by creating the initial Colour Platte I would use throughout the website, as seen below:

![Image of Website Colour Palette](https://benking.co.nz/Images/PortfolioSite/ColourPalette.png)

From this I then started by creating a new Project in Visual Studio 2019, and starting by coding initially the Home Page, with the Navbar, Header on it. Once I was happy with the design and look, I then moved the Elements that would be repeated on all the Pages to the View_Layouts File, which would mean I would not have to retype the code on each page, and incorporating a Feature from ASPNet.Core MVC. 

From here I then continued by working on the About Page, as well as the Resume Page. On the About Page I wanted to have it very personal while professional, so decided to include some fun facts such as my favourite food, current book etc. I also decided to showcase my key talents such as the Programming Languages I have experience with.

On my Contact Page I decided to reuse some C# Code from one of my previous applications (a SendEmail Application), so that the Form would create a Model (Part of the MVC Process) which it would then run a C# Class using the **Mailkit** Library, sending this to my email Address from the Domain Email using SMTP. This required me fining my SMTP Settings for my Domain Provided Email (Provided through Octopoly), as well as fine tuning my C# class so it would send the email in a nice presentable Format. I enhanced the class so that it would send 2 Emails, 1 to me for every enquiry as well as 1 to the person who filled it in so that they had a record of their Message and Details they entered in.

The last page that I created and designed was the Portfolio Webpage and designed it around the **Gallery Template** that Bootstrap had. The Portfolio Page took longer than I anticipated due to how I had to upload all the projects onto GitHub as well as create ReadMe Files for each project, and then create the Project on the Portfolio Page with the accompanying Photo.

Throughout this Project I continuously published the Website at the end of each page’s creation so that I could easily see the pages as a Final Product.
	
# Uploaded Version
The Uploaded Version on GitHub of my ASPNet.Core Portfolio Website is a 90% complete version of the same website published online at https://benking.co.nz. However, there are some slight differences such as the removal of Login Details for the SMTP Server used for the Contact Form, as well as minor changes in the content (such as the Current Book I'm Reading).

# Conclusion
So to Summarise my Summer Project for the 2019-2020 Summer Break was to create a ASPNet.Core Website that allowed me to showcase my talent to future employers, as well as clients in the future. Throughout the development of this website I used several features that I learnt in my Year 2 Web Development Course at the Southern Institute of Technolgoy, while also including some self researched/taught features such as the ability to send a ASPNet.Core MVC Model to an Email Address. Unlike several of my classmates at SIT who were creating their own websites I created this one from scratch, coding the individual HTML and CSS that is featured on it (while including some BootStrap CSS), not using a premade template or a Website Builder.

# References
I Referred to and used several Examples from the Bootstrap Documentation Website
https://getbootstrap.com/

I used this free Sample Bootstrap Code of a Timeline for my Resume Page:
https://bootsnipp.com/snippets/xrKXW

I used the MailKit Documentation on the GitHub Page for the Library to understand how to use Mailkit
https://github.com/jstedfast/MailKit

Most Images I used on my Website I owned. However, I did use the following Images on my website's Home Page from **Free to Reuse** Websites:
Portfolio Icon: https://www.flaticon.com/free-icons/briefcase
Resume Icon: https://icons8.com/icons/set/resume
About Me Icon: https://freesvg.org/users-profile-icon

Other Icons featured on my website such as the LinkedIn, GitHub and icons on the Contact Page were sourced from the **Font Awesome Collection**	

@Benjamin King

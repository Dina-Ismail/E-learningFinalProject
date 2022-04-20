# E-learningFinalProject
Final Project for ASP.NET Course
#### Point number 1 : In README.md, describe roles authentication and authorization related to the theme/website.
- I have 3 Main roles (Admin, Office, Teacher)
- Admin Can see all links and do all the functionality without any restriction
- Teacher Can see only the Student CRUD (Student Controller) 
- Office can see and do all the CRUD functions for the 5 links (Student, professors, semesters, Schedule for the semester)

 #### Point number 2 : Add Design View screenshots of all the tables in the README.md
  1. Students table
<img width="966" alt="image" src="https://user-images.githubusercontent.com/85464890/164309051-82634136-80c2-447b-9a7c-ca9c7ead5ee0.png">
  
  2. Semester table
  <img width="966" alt="image" src="https://user-images.githubusercontent.com/85464890/164309406-e9046bbf-f16d-454b-921a-c2519a79963a.png">

  3. Course table
  <img width="966" alt="image" src="https://user-images.githubusercontent.com/85464890/164309525-762eb76c-350d-4b54-a0a8-6db110ce309c.png">

  4. Professor table
  <img width="966" alt="image" src="https://user-images.githubusercontent.com/85464890/164309455-36a089ee-478e-4590-95f3-875fd06040c6.png">

  5. Semeseter Schedule table
  <img width="966" alt="image" src="https://user-images.githubusercontent.com/85464890/164309342-33654ddb-ef68-4fbe-88da-8941fbdecf88.png">

  6. Student Schedule table
  <img width="966" alt="image" src="https://user-images.githubusercontent.com/85464890/164309265-f29259af-f622-4fa7-8e21-a444cce1a181.png">

   #### Point number 3 : Add the screenshot of web pages in README.md
  1. Student Screen 
  <img width="960" alt="image" src="https://user-images.githubusercontent.com/85464890/164309862-cca2d4a3-b95b-4347-887e-9d8e76a6a99a.png">
  
  2. Courses Screen
  <img width="960" alt="image" src="https://user-images.githubusercontent.com/85464890/164309936-68560f7a-c4f5-4341-ba12-d4358366b0a3.png">
  
  3. Semesters Screen
  <img width="960" alt="image" src="https://user-images.githubusercontent.com/85464890/164310032-3b04d88d-8357-44c0-9182-5914d5f49a4b.png">

  4. Professors Screen
  <img width="960" alt="image" src="https://user-images.githubusercontent.com/85464890/164310108-fc278056-5271-4b52-93bb-b33fe5ca3644.png">

  5. Semester' Schedule Screen
  <img width="960" alt="image" src="https://user-images.githubusercontent.com/85464890/164310215-8dfdf4b3-be0b-40d8-a038-adda132cdf6a.png">

  6. Students' Schedule Screen
  <img width="960" alt="image" src="https://user-images.githubusercontent.com/85464890/164310259-edf6b413-9a15-43ea-8f81-8b871d2ad2a2.png">
  
  7. Add Role Screen
<img width="960" alt="image" src="https://user-images.githubusercontent.com/85464890/164310328-dec3d30e-3657-459d-90ed-9ee6dcd1468e.png">

  8. Edit Role Screen
  <img width="960" alt="image" src="https://user-images.githubusercontent.com/85464890/164310408-9fec2bc1-186d-4cff-b9d2-a1bfd97f62ed.png">

   #### Point number 4 : •	Authorize minimum 1 action result in a controller and mention in your README.md
#### •	Hide minimum 2 Links based on role and mention in your README.md
#### •	Authorize by multiple roles on a controller based on roles (minimum 2 required)

- I added an Authorization annotation for the Action Result from the Edit Role method to minimize it to be only for Admin
        [Authorize(Policy ="AdminRolePolicy")]
        public async Task<IActionResult> EditRole(EditRoleViewModel model)
  - Links are hidden according to the role. e.g. Teacher can only see Student link, same for office, can't see the manage role drop down menu
  - To be able to change the student schedule the user needs to be part of both roles Office and Admin (StudentSchedulesController)

  

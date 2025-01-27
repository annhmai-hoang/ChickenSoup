# ChickenSoup Journal WebApp

## Description
ChickenSoup is a simple journal web application where you can log little events and upload pictures of your favorite memories. Whether it's a sunny day, a graduation, or a favorite pet, you can capture the moment and create entries with images. The app also includes a jolly button for those rainy days to hopefully bring a smile to your face!

## Features
- **Create Entries**: Log your experiences, add descriptions, and categorize your entries.
- **Upload Pictures**: Upload and display images along with your entries.
- **Jolly Button**: A fun, motivational button to brighten up your day!

## Prerequisites
- [.NET 6 SDK or higher](https://dotnet.microsoft.com/download) 
- A text editor like [Visual Studio Code](https://code.visualstudio.com/) or [Visual Studio](https://visualstudio.microsoft.com/)

## How to Build and Run the Project

1. **Clone the repository**:
   ```bash
   git clone https://github.com/yourusername/chickensoup.git
   cd chickensoup
   ```
   
2. **Install Dependencies**: If you haven't done so yet, make sure you have [.NET 6 SDK](https://dotnet.microsoft.com/download) installed.

Then, restore the necessary packages by running:
   ```bash
   dotnet restore
   ```

3. **Set Up the Database**:
* The application uses **Entity Framework Core** for data access.
* Run the following command to apply the database migrations and set up your tables:
   ```bash
   dotnet ef database update
   ```

4. **Prepare Images for Upload**:
* In this app, images are uploaded and saved to the `/wwwroot/images/` folder.
* Before uploading any images, make sure that the image files are located in the wwwroot/images/ directory.
* There are some sample images, feel free to try them out! But don't delete them, some are used to seed the initial run.

5. **Run the application**: To run the application locally, use the following command:
   ```bash
   dotnet run
   ```
   This will start the app on `https://localhost:XXXX` by default. Open it in your browser to begin logging your journal entries.

## Configuring the Database Connection

The application uses **Entity Framework Core** to connect to the database. By default, it uses a local database connection.

### Connection String

You might need to update the connection string depending on your environment.

1. **Locate the `appsettings.json` file**: In the root directory of the project, open the `appsettings.json` file.

2. **Modify the connection string**: The connection string is located under the `ConnectionStrings` section. Make sure to update it according to your environment, whether you're using a local database or a cloud-hosted one.

   Example for a local database:

   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=ChickenSoupDb;Trusted_Connection=True;TrustServerCertificate=True;Integrated Security=False;"
     }
   }
    ```

3. **Test your connection**: After updating the connection string, run the application and make sure it can connect to the database successfully. If there are any issues, check the connection string and database configuration.

## Usage
* **Creating an entry**: After logging in, you can add a new journal entry by clicking the "Create" button. Fill in the description, category, and optionally upload a picture.
* **Viewing entries**: All your entries, including images, will be displayed in a gallery. You can scroll through to revisit your memories.
* **Fun Button**: For those rainy days, press the "I'm having an awful day!" button to receive a fun motivational message to lift your spirits.

## Troubleshooting
1. If you're unable to upload images, double-check that:
* The image files are stored in the wwwroot/images/ folder.
* The image file extension is valid (JPG, PNG, GIF).
* The app is running with the necessary permissions to write to the wwwroot/images/ folder.
  
2. If the database fails to update or is missing entries, try running the migration commands again:
    ```bash
    dotnet ef database update
    ```
  






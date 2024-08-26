# Social Media API

Welcome to the Social Media API! This API is built with .NET 8 and provides the
backend services for a social media application. It supports a range of features
to manage user profiles, interactions, and content.

## Features

- **User Profiles**: Create, update, and manage user profiles.
- **Follows**: Follow and unfollow other users.
- **Likes**: Like comments and posts.
- **Notifications**: Receive notifications for various activities.
- **Posts**: Create, view, update, and delete posts.
- **Direct Messages**: Send and receive direct messages.

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download) installed on your machine.
- A SQL Server database or other supported database for persistence.

### Installation

1. **Clone the repository**:

   ```bash
   git clone https://github.com/yourusername/social-media-api.git

   ```

2. **Navigate to the project directory**:

   ```bash
   cd social-media-api

   ```

3. **Restore the project dependencies:**:

   ```bash
   dotnet restore

   ```

4. **Update your appsettings.json file with your database connection string and
   any other configuration settings.**

5. **Apply database migrations (if using Entity Framework) this will also seed
   some data to make it easier to test.**

   ```bash
   dotnet ef database update

   ```

6. **Run the application:**
   ```bash
   dotnet run
   ```

## API Endpoints

### User Profiles

- **Retrieve a User Profile**

  - `GET /api/users/{id}`
  - Retrieves the user profile for the specified user ID.

- **Create a New User Profile**

  - `POST /api/users`
  - Creates a new user profile.

- **Update a User Profile**

  - `PUT /api/users/{id}`
  - Updates the user profile for the specified user ID.

- **Delete a User Profile**
  - `DELETE /api/users/{id}`
  - Deletes the user profile for the specified user ID.

### Follows

- **Follow a User**

  - `POST /api/follow/{userId}`
  - Follows the user with the specified user ID.

- **Unfollow a User**
  - `DELETE /api/follow/{userId}`
  - Unfollows the user with the specified user ID.

### Likes

- **Like a Post**

  - `POST /api/posts/{postId}/like`
  - Likes the post with the specified post ID.

- **Unlike a Post**

  - `DELETE /api/posts/{postId}/like`
  - Unlikes the post with the specified post ID.

- **Like a Comment**

  - `POST /api/comments/{commentId}/like`
  - Likes the comment with the specified comment ID.

- **Unlike a Comment**
  - `DELETE /api/comments/{commentId}/like`
  - Unlikes the comment with the specified comment ID.

### Notifications

- **Retrieve Notifications**

  - `GET /api/notifications`
  - Retrieves notifications for the logged-in user.

- **Mark Notification as Read**

  - `PUT /api/notifications/{id}`
  - Marks the notification with the specified ID as read.

- **Delete a Notification**
  - `DELETE /api/notifications/{id}`
  - Deletes the notification with the specified ID.

### Posts

- **Retrieve All Posts**

  - `GET /api/posts`
  - Retrieves a list of all posts.

- **Retrieve a Specific Post**

  - `GET /api/posts/{id}`
  - Retrieves the post with the specified post ID.

- **Create a New Post**

  - `POST /api/posts`
  - Creates a new post.

- **Update a Post**

  - `PUT /api/posts/{id}`
  - Updates the post with the specified post ID.

- **Delete a Post**
  - `DELETE /api/posts/{id}`
  - Deletes the post with the specified post ID.

### Direct Messages

- **Retrieve All Direct Messages**

  - `GET /api/messages`
  - Retrieves all direct messages for the logged-in user.

- **Send a New Direct Message**

  - `POST /api/messages`
  - Sends a new direct message.

- **Retrieve a Specific Message**

  - `GET /api/messages/{id}`
  - Retrieves the direct message with the specified ID.

- **Delete a Direct Message**
  - `DELETE /api/messages/{id}`
  - Deletes the direct message with the specified ID.

# Email Service

## Overview
This project provides a simple C# class (`EmailService`) that allows you to send emails using SMTP servers, such as Gmail, via the .NET `System.Net.Mail` namespace. The project demonstrates how to configure SMTP settings, create and send email messages, and handle potential errors.

## Features
- Send emails using SMTP
- Supports secure SSL/TLS connections
- Customizable sender, recipient, subject, and body content
- Option to send HTML-formatted emails

## Requirements
- .NET Framework or .NET Core
- SMTP Server (e.g., Gmail)
- App-specific password (if using Gmail with 2FA)

## Configuration
Ensure you have the following SMTP server details for proper configuration:
- **SMTP Server**: The server address for the email service (e.g., `smtp.gmail.com` for Gmail).
- **SMTP Port**: The port number used for sending emails (`587` for Gmail with `STARTTLS`).
- **SMTP Username**: Your email address.
- **SMTP Password**: For Gmail, use an **App-specific password** if 2-factor authentication is enabled.
- **Enable SSL**: Set to `true` to use a secure connection.

### Example Configuration for Gmail:
```csharp
var emailService = new Emailservice(
    smtpServer: "smtp.gmail.com",
    smtpPort: 587,
    smtpUsername: "your-email@gmail.com",  // Replace with your email
    smtpPassword: "your-app-password",     // Use app-specific password if 2FA is enabled
    enableSsl: true
);

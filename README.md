# 🌍 CivicMap – Local Policy Impact Tracker

**CivicMap** is a mobile app that helps users understand how local government policies (e.g., housing, transit, taxation) affect them based on their location. It simplifies complex policy data into actionable insights and provides notifications about relevant changes in their area.

---

## 📱 Features

### Core Features
- 🔍 **Location-Based Feed** – View city and municipal policies relevant to your region
- 🗂 **Policy Categorization** – Filter by housing, transit, taxes, and more
- 🧠 **Plain Language Summaries** – Understand complex policy documents easily
- 📆 **Timeline View** – Track upcoming policy implementations and voting dates
- 🧭 **Personal Impact Tracker** – Get insights into how policies might affect your rent, commute, or services

### Optional Enhancements
- ✉️ Push notifications when a new policy affects your region
- 💬 GPT-powered summarization of legal documents (add a chatBot to further summarize in layment's terms)
- 🗳  Voting reminders and polling station lookup
- 📊 Analytics for comparing cities by policy category
- 🧮 Visuals for completion rates, user interaction trends, etc.

---

## 🧱 Tech Stack

### Frontend (Mobile App)
- **React Native** + **TypeScript**
- **Styled Components**
- **React Navigation**
- **react-native-maps**, **expo-location**
- **Firebase Cloud Messaging** (push notifications)

### Backend
- **ASP.NET Core Web API**
- **GraphQL** using [HotChocolate](https://chillicream.com/docs/hotchocolate)
- **Entity Framework Core** (ORM)
- **JWT Authentication** (optional)

### Database
- **SQL Server** hosted via **Azure SQL Free Tier**

### Infrastructure & DevOps
- **Docker** for containerization
- **Kubernetes** via **Azure Kubernetes Service (AKS)**
- **CI/CD** using **GitHub Actions**
- **Azure Key Vault** for secure secrets
- **Azure Monitor** for performance logs and diagnostics

### Optional Services
- **Azure Functions** / **Hangfire** for scheduled data parsing
- **Azure Blob Storage** for document storage
- **Azure Redis Cache** for policy lookup caching

---

## 📦 Folder Structure (Example)

```bash
/civicmap-backend
  ├── Controllers/
  ├── GraphQL/
  ├── Services/
  ├── Data/
  ├── Models/
  └── Program.cs

/civicmap-mobile
  ├── components/
  ├── screens/
  ├── services/
  ├── hooks/
  └── App.tsx

/docs
  └── architecture.md
  └── graphql-schema.md
```

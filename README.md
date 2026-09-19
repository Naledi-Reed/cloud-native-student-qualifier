<div align="center">

# ☁️ Cloud Native Student Qualifier

**A buildable C#/.NET 8 console application packaged with Docker**

[![Build .NET project](https://github.com/Naledi-Reed/cloud-native-student-qualifier/actions/workflows/dotnet.yml/badge.svg)](https://github.com/Naledi-Reed/cloud-native-student-qualifier/actions/workflows/dotnet.yml)

[![Source](https://img.shields.io/badge/OPEN_C%23_SOURCE-B6FF00?style=for-the-badge&logo=dotnet&logoColor=07110D)](src/Program.cs)
[![Project File](https://img.shields.io/badge/OPEN_PROJECT_FILE-101820?style=for-the-badge&logo=dotnet&logoColor=B6FF00)](src/StudentQualificationApp.csproj)
[![Download](https://img.shields.io/badge/DOWNLOAD_COMPLETE_PROJECT-B6FF00?style=for-the-badge&logo=github&logoColor=07110D)](https://github.com/Naledi-Reed/cloud-native-student-qualifier/archive/refs/heads/main.zip)

</div>

## What it does

The application accepts four assessment marks, validates the input, calculates the weighted semester result and reports whether the student qualifies to write the exam.

| Assessment | Weight |
|---|---:|
| Test 1 | 30% |
| Test 2 | 50% |
| Assignment 1 | 10% |
| Project | 10% |

## Actual project files

| File | Purpose |
|---|---|
| [src/Program.cs](src/Program.cs) | Complete application logic and validation |
| [src/StudentQualificationApp.csproj](src/StudentQualificationApp.csproj) | Buildable .NET 8 project definition |
| [Dockerfile](Dockerfile) | Multi-stage container build |
| [.dockerignore](.dockerignore) | Docker build exclusions |
| [docs/CLI-GUIDE.md](docs/CLI-GUIDE.md) | Command-line and Docker guidance |
| [CNA261 portfolio report](docs/CNA261_Student_Qualifier_Portfolio_Report.pdf) | Sanitised PDF edition of the original assignment report |
| [evidence/](evidence/) | Selected execution evidence |

## Run with .NET 8

```bash
dotnet restore src/StudentQualificationApp.csproj
dotnet run --project src/StudentQualificationApp.csproj
```

Marks can also be supplied as arguments:

```bash
dotnet run --project src/StudentQualificationApp.csproj -- 65 70 80 75
```

## Run with Docker

```bash
docker build -t student-qualifier .
docker run --rm student-qualifier 65 70 80 75
```

For interactive input:

```bash
docker run --rm -it student-qualifier
```

## What this demonstrates

C# application logic • input validation • weighted calculations • .NET builds • multi-stage Docker builds • CLI execution • technical documentation

**Module origin:** CNA261 — Cloud Native Programming  
**Status:** Runnable portfolio project with source and build files

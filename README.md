# BackendSan (.NET 8 API)

This project builds a Docker image hosted on [Docker Hub](https://hub.docker.com/repository/docker/phantosys/backendsan).

The backend supports the [Frontend Repo](https://github.com/phantosys/SanTSG-Frontend) built during the SAN TSG 2025 Summer Internship Program.

## 🔧 How to Run the Docker Image

```bash
docker run -p 5045:5045 \
  -e "TargetApi__BaseUrl=https://api.example.com" \
  -e "TargetApi__User=myuser" \
  -e "TargetApi__Password=secret" \
  -e "TargetApi__Agency=abc" \
  phantosys/backendsan:latest
```
Make sure to replace the values with your own credentials.

API will be available at: http://localhost:5045

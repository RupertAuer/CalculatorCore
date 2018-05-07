pipeline {
  agent {
    docker {
      image 'docker'
    }

  }
  stages {
    stage('build') {
      parallel {
        stage('DOTNET') {
          agent {
            docker {
              image 'microsoft/dotnet'
            }

          }
          steps {
            sh 'dotnet build'
          }
        }
        stage('ASPNETCORE') {
          agent {
            docker {
              image 'microsoft/aspnetcore-build:latest'
            }

          }
          steps {
            sh 'dotnet build'
          }
        }
      }
    }
    stage('Test') {
      parallel {
        stage('Test') {
          agent {
            docker {
              image 'microsoft/dotnet'
            }

          }
          steps {
            sh 'dotnet test'
          }
        }
        stage('error') {
          agent {
            docker {
              image 'microsoft/aspnetcore-build:latest'
            }

          }
          steps {
            sh 'dotnet test'
          }
        }
      }
    }
    stage('error') {
      agent {
        docker {
          image 'microsoft/dotnet'
        }

      }
      steps {
        sh 'dotnet test -t'
      }
    }
  }
}
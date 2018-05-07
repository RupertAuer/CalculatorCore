pipeline {
  agent {
    docker {
      image 'docker'
    }

  }
  stages {
    stage('Git') {
      agent any
      steps {
        git(url: 'https://github.com/RupertAuer/CalculatorCore', branch: 'master', poll: true)
      }
    }
    stage('Build') {
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
        stage('ASPCORE') {
          agent {
            docker {
              image 'microsoft/aspnetcore-build'
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
            sh 'dotnet test -t'
          }
        }
        stage('ASPCORE') {
          agent {
            docker {
              image 'microsoft/aspnetcore-build'
            }

          }
          steps {
            sh 'dotnet test'
            sh 'dotnet test -t'
          }
        }
      }
    }
    stage('Docker Publish ') {
      agent {
        docker {
          image 'docker'
        }

      }
      steps {
        script {
          docker.withRegistry([ credentialsId: "docker-hub-credentials", url: "https://registry.hub.docker.com" ]) {
            sh 'docker build -t rupertauer1991/letsgettingstarted:latest .'
            sh 'docker push rupertauer1991/letsgettingstarted:latest'
          }
        }

      }
    }
  }
}
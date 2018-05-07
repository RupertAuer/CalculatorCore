pipeline {
  agent {
    docker {
      image 'docker'
    }

  }
  stages {
    stage('git') {
      steps {
        git(url: 'https://github.com/RupertAuer/CalculatorCore.git', branch: 'master', poll: true)
      }
    }
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
      agent {
        docker {
          image 'microsoft/dotnet'
        }

      }
      steps {
        sh 'dotnet test'
      }
    }
  }
}
pipeline {
  agent {
    docker {
      image 'docker'
    }

  }
  stages {
    stage('Git') {
      steps {
        git(url: 'https://github.com/RupertAuer/CalculatorCore', branch: 'master', poll: true)
      }
    }
    stage('Build') {
      agent {
        docker {
          image 'microsoft/dotnet'
        }

      }
      steps {
        sh 'dotnet build'
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
        stage('List Tests') {
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
    stage('') {
      agent {
        docker {
          image 'microsoft/dotnet'
        }

      }
      steps {
        sh 'dotnet run'
      }
    }
  }
}
pipeline {
  agent {
    docker {
      image 'microsoft/dotnet'
    }

  }
  stages {
    stage('build') {
      steps {
        sh 'dotnet build'
      }
    }
    stage('Test') {
      parallel {
        stage('Test') {
          steps {
            sh 'dotnet test'
          }
        }
        stage('') {
          steps {
            sh 'dotnet test -t'
          }
        }
      }
    }
    stage('Publish') {
      steps {
        sh 'dotnet publish'
      }
    }
  }
}
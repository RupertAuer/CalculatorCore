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
      steps {
        sh 'dotnet test '
      }
    }
    stage('') {
      steps {
        powershell 'docker container ls -a'
      }
    }
  }
}
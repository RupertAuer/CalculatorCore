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
    stage('Docker commands') {
      steps {
        sh 'docker container ls -a'
      }
    }
  }
}
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
      agent {
        docker {
          image 'microsoft/dotnet'
        }

      }
      steps {
        sh 'dotnet build'
      }
    }
  }
}
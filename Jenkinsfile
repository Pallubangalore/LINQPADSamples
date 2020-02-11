pipeline {
    agent any
    tools { 
        maven 'maven_3_5_0' 
        
    }
    stages {
        stage ('Initialize') {
            steps {
                echo 'This is initialize step in pipeline.'
            }
        }

        stage ('Build') {
            steps {
                echo 'This is a minimal pipeline.'
            }
        }
    }
}

pipeline {
    agent any

    stages {
        stage ('Compile Stage') {

            steps {
                tools {
         maven '3.5.0' 
		 sh 'mvn clean compile'
    }
                    
                }
            }
        }

        stage ('Testing Stage') {

            steps {
                tools {
         maven '3.5.0' 
		 sh 'mvn clean compile'
    }
            }
        }


        stage ('Deployment Stage') {
            steps {
                tools {
         maven '3.5.0' 
		 sh 'mvn clean compile'
    }
            }
        }
    }
}

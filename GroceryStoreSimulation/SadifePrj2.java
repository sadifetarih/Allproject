
package Proje2;

public class SadifePrj2 {

    public static void main(String[] args) {
        calculate();
    }

    public static void calculate() {
        int numberOfCustomer = 10000000;
        int[][] array = new int[numberOfCustomer][9];
        array[0][0] = 1;
        array[0][1] = 0;
        array[0][2] = 0;
        array[0][3] = SadifePrj2.randomServiceTime(); // to create random number for service time 
        array[0][4] = 0;
        array[0][5] = array[0][4] - array[0][2];
        array[0][6] = array[0][3] + array[0][4];
        array[0][7] = array[0][6] - array[0][2];
        array[0][8] = 0;

        double totalTimeCustomersWaitInQue = 0;
        double totalIdleTimeOfServer = 0;
        double totalRunTime = 0;
        double totalServiceTime = 0;
        double sumOfTimesBetweenArrivals = array[0][3];
        double numberOfCustomerWhoWait = 0;

        for (int i = 1; i < numberOfCustomer; i++) {
            array[i][0] = i + 1;
            array[i][1] = SadifePrj2.randomArrivalTime();// to create random number for arrival time 
            array[i][2] = array[i][1] + array[i - 1][2];
            array[i][3] = SadifePrj2.randomServiceTime();
            array[i][4] = Math.max(array[i][2], array[i - 1][6]);
            array[i][5] = array[i][4] - array[i][2];
            array[i][6] = array[i][4] + array[i][3];
            array[i][7] = array[i][6] - array[i][2];
            array[i][8] = Math.max((array[i][2] - array[i - 1][6]), 0);

            if (array[i][5] != 0) {
                numberOfCustomerWhoWait++;
                totalTimeCustomersWaitInQue = totalTimeCustomersWaitInQue + array[i][5];
            }
            totalIdleTimeOfServer = totalIdleTimeOfServer + array[i][8];
            totalServiceTime = totalServiceTime + array[i][3];
        }
        System.out.println("The simulation system works on " + numberOfCustomer +" customers");
        System.out.println("Avg time Customer spend in the system : " + (totalTimeCustomersWaitInQue / numberOfCustomer + totalServiceTime / numberOfCustomer));
        System.out.println("Avg waiting time of a customer : " + totalTimeCustomersWaitInQue / numberOfCustomer);
        System.out.println("Avg service time of a customer : " + totalServiceTime / numberOfCustomer);
        System.out.println("Percentage of the customers wait at the checkout counter: " + numberOfCustomerWhoWait / numberOfCustomer);
        System.out.println("Avg waiting time of those who wait : " + totalTimeCustomersWaitInQue / numberOfCustomerWhoWait);
        System.out.println("Probability of idle server: " + totalIdleTimeOfServer / array[numberOfCustomer - 1][6]);
        System.out.println("Average time between arrivals to the checkout counter : " + (double) (array[numberOfCustomer - 1][2]) / (numberOfCustomer - 1));
    }

    public static int randomServiceTime() {
        //Probability of Service Time Distribution. 
        //Firstly, to calculate Icm probability of service time  
        // 30--->1          [1-30]--->1
        // 60--->2          [31-90]--->2
        // 90--->3          [91-180]--->3
        // 75--->4          [181-255]--->4
        // 30--->5          [256-285]--->5
        // 15--->6          [286-300]--->6

        int getRnd = ((int) (Math.random() * (300))) + 1;

        if (getRnd <= 30) {
            getRnd = 1;
        } else if (getRnd >= 31 && getRnd <= 90) {
            getRnd = 2;
        } else if (getRnd >= 91 && getRnd <= 180) {
            getRnd = 3;
        } else if (getRnd >= 181 && getRnd <= 255) {
            getRnd = 4;
        } else if (getRnd >= 256 && getRnd <= 285) {
            getRnd = 5;
        } else if (getRnd >= 286 && getRnd <= 300) {
            getRnd = 6;
        }
        return getRnd;
    }

    public static int randomArrivalTime() {
        // Arrival times have the same probability 
        // So, we don't need to check the probability to create random variable
        int getRnd2 = ((int) (Math.random() * (8))) + 1;
        return getRnd2;
    }

}

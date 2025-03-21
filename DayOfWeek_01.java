package ArrayExerccise;

import java.util.Scanner;

public class DayOfWeek_01 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
       String[] day = {"Monday",
                       "Tuesday",
                       "Wednesday",
                       "Thursday",
                      "Friday",
                      "Saturday",
                      "Sunday"};
       int dayIndex = Integer.parseInt(scanner.nextLine());
       if (dayIndex > 0 && dayIndex <= 7){
           System.out.println(day[dayIndex - 1]);
       }else {
           System.out.println("Invalid day!");
       }
    }
}

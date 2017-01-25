package hw2;
import hw2.GUI;
import java.util.ArrayList;
import java.util.Random;
import javafx.scene.canvas.Canvas;
import javafx.scene.canvas.GraphicsContext;
import javafx.scene.paint.Color;

// 3 points
// manages and draws figures
public class FigureCanvas extends Canvas {
	private ArrayList<Figure> list; // contains figures
	private int capacity; // determines the max number of figures in the list
	private GraphicsContext gc; // used for drawing figures
	private GUI myGUI; // points to the GUI object
	private Figure fig_selected; // lastly selected figure
        
	// 0.4 point
	// initialization
	public FigureCanvas(int capacity, int width, int height, GUI myGUI) {
		// ################ COMPLETE ################
                super(width, height);
                list = new ArrayList<Figure>();
                this.capacity = capacity;
                this.myGUI = myGUI;
                
		// getGraphicsContext2D is a method of Canvas returning GraphicsContext object,
		// which is used for drawing figures
		gc = getGraphicsContext2D();
		// draws a rectangle on the border of the canvas
		gc.strokeRect(0, 0, width, height);
                
                
	}

	// 1.6 point
	// create and add a figure into the list if the size is less than the capacity.
	// If the capacity is full, only display the message "Capacity FULL !" on GUI by calling setText method of GUI.
	// the center point and size of the figure is randomly determined based on width and height of the canvas.
	// draw the added figure by calling draw method of the figure.
	// display the added figure's information on GUI by calling setText method of GUI
	public void addFigure(int figure, Color c) {
		// ################ COMPLETE ################
            Random rnd = new Random();
            
            if (list.size()==10 || list.size()>10) 
                    myGUI.setText("CAPACITY FULL!!!");
            else{
                if (figure==0) {
                Figure fs = new Square(rnd.nextInt(401), rnd.nextInt(501), rnd.nextInt(101), c);

                list.add(fs);
                fs.draw(gc);
                myGUI.setText(fs.toString());
            }
            else if (figure==1) {
                Figure fs = new Circle(rnd.nextInt(400), rnd.nextInt(501), rnd.nextInt(51), c);

                list.add(fs);
                fs.draw(gc);
                myGUI.setText(fs.toString());
            }
            else{
               Figure fs = new Rectangle(rnd.nextInt(400), rnd.nextInt(501), rnd.nextInt(201), rnd.nextInt(251), c);

                list.add(fs);
                fs.draw(gc);
                myGUI.setText(fs.toString());
            }
            }                 
	}

	// 0.6 point
	// select the figure containing the given (x, y) coordinates
	public void selectFigureContaining(double x, double y) {
		String str = "";
		Figure fig_current = null; // points the figure containing the given (x, y) coordinates
		
		// 0.2 point
		// ################ COMPLETE ################
		// fig_selected is the previously selected figure.
		// here, we compare both previously selected and current figures.
            
		if (fig_selected != null && fig_current != null) {
			str += fig_selected + "\n";
			int res = fig_selected.compareTo(fig_current);
			if (res > 0)
				str += ">";
			else if (res < 0)
				str += "<";
			else
				str += "==";
			str += "\n" + fig_current;
		}
		fig_selected = fig_current;

		// 0.2 point
		// display comparison information on GUI through setText method call
		// ################ COMPLETE ################
               myGUI.setText(str);
               myGUI.toString();

	}

	// 0.4 point
	// clear all figures in the list and do the necessary updates.
	// clearRect method of GraphicsContext object may be useful.
	// display the message "Cleaned !" on GUI by calling setText method of GUI.
	public void removeAll() {
		// ################ COMPLETE ################
               list.clear();
               gc.clearRect(1, 1, 398, 498);
               myGUI.setText("Cleaned !");

	}
}

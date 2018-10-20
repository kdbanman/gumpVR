public class RenderableEnvironment {

  private byte[][][] environment;

  // TODO coordinate list, danger coordinate list

  public RenderableEnvironment(int xSize, int ySize, int zSize) {
    environment = new byte[xSize][][];

    for (int x = 0; x < xSize; x++) {
      environment[x] = new byte[ySize][];

      for (int y = 0; y < ySize; y++) {
        environment[x][y] = new byte[zSize];
      }
    }
  }
}

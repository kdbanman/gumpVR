public class EnvironmentBuffer {

  // Many environments in 1D buffer.  Still sparse in each (x, y, z) environment because
  // coordinates are simple that way.
  private byte[] environments;

  public int BufferSize { get; private set; }
  public int XSize { get; private set; }
  public int YSize { get; private set; }
  public int ZSize { get; private set; }

  public int currentEnvironment { get; private set; }

  public EnvironmentBuffer(int bufferSize, int xSize, int ySize, int zSize) {
    environments = new byte[bufferSize * xSize * ySize * zSize];

    BufferSize = bufferSize;
    XSize = xSize;
    YSize = ySize;
    ZSize = zSize;
  }

  private int getIndex(int environment, int x, int y, int z) {
    int environmentSkip = environment * XSize * YSize * ZSize;
    int xSkip = x * YSize * ZSize;
    int ySkip = y * ZSize;

    return environmentSkip + xSkip + ySkip + z;
  }

  private byte getState(int environment, int x, int y, int z) {
    return environments[getIndex(environment, x, y, z)];
  }

  private void setState(int environment, int x, int y, int z, byte newState) {
    environments[getIndex(environment, x, y, z)] = newState;
  }
}

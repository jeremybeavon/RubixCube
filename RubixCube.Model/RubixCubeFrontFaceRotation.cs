namespace RubixCube.Model
{
    internal class RubixCubeFrontFaceRotation
    {
        private readonly RubixCubeFrontFace newFrontFace;
        private readonly RubixCubeTopFace oldTopFace;
        private readonly RubixCubeTopFace newTopFace;
        private readonly RubixCubeLeftFace oldLeftFace;
        private readonly RubixCubeLeftFace newLeftFace;
        private readonly RubixCubeRightFace oldRightFace;
        private readonly RubixCubeRightFace newRightFace;
        private readonly RubixCubeBottomFace oldBottomFace;
        private readonly RubixCubeBottomFace newBottomFace;

        public RubixCubeFrontFaceRotation(RubixCube cube, RubixCubeFrontFace newFrontFace)
        {
            this.newFrontFace = newFrontFace;
            oldTopFace = cube.TopFace;
            newTopFace = oldTopFace.Clone();
            oldLeftFace = cube.LeftFace;
            newLeftFace = oldLeftFace.Clone();
            oldRightFace = cube.RightFace;
            newRightFace = oldRightFace.Clone();
            oldBottomFace = cube.BottomFace;
            newBottomFace = oldBottomFace.Clone();
            UpdateFaces();
            RemoveOldCubes();
            AddNewCubes();
        }

        public RubixCubeTopFace NewTopFace
        {
            get { return newTopFace; }
        }

        public RubixCubeLeftFace NewLeftFace
        {
            get { return newLeftFace; }
        }

        public RubixCubeRightFace NewRightFace
        {
            get { return newRightFace; }
        }

        public RubixCubeBottomFace NewBottomFace
        {
            get { return newBottomFace; }
        }

        private void UpdateFaces()
        {
            newTopFace.FrontLeftCube = newFrontFace.TopLeftCube;
            newTopFace.FrontCube = newFrontFace.TopCube;
            newTopFace.FrontRightCube = newFrontFace.TopRightCube;
            newLeftFace.FrontTopCube = newFrontFace.TopLeftCube;
            newLeftFace.FrontCube = newFrontFace.LeftCube;
            newLeftFace.FrontBottomCube = newFrontFace.BottomLeftCube;
            newRightFace.FrontTopCube = newFrontFace.TopRightCube;
            newRightFace.FrontCube = newFrontFace.RightCube;
            newRightFace.FrontBottomCube = newFrontFace.BottomRightCube;
            newBottomFace.FrontLeftCube = newFrontFace.BottomLeftCube;
            newBottomFace.FrontCube = newFrontFace.BottomCube;
            newBottomFace.FrontRightCube = newFrontFace.BottomRightCube;
        }

        private void RemoveOldCubes()
        {
            oldTopFace.FrontLeftCube.RemoveCubeWith2Faces(oldTopFace.LeftCube);
            oldTopFace.CenterCube.RemoveCubeWith2Faces(oldTopFace.FrontCube);
            oldTopFace.FrontRightCube.RemoveCubeWith2Faces(oldTopFace.RightCube);
            oldLeftFace.CenterCube.RemoveCubeWith2Faces(oldLeftFace.FrontCube);
            oldRightFace.CenterCube.RemoveCubeWith2Faces(oldRightFace.FrontCube);
            oldBottomFace.FrontLeftCube.RemoveCubeWith2Faces(oldBottomFace.LeftCube);
            oldBottomFace.CenterCube.RemoveCubeWith2Faces(oldBottomFace.FrontCube);
            oldBottomFace.FrontRightCube.RemoveCubeWith2Faces(oldBottomFace.RightCube);
        }

        private void AddNewCubes()
        {
            newTopFace.FrontLeftCube.AddCubeWith2Faces(newTopFace.LeftCube);
            newTopFace.CenterCube.AddCubeWith2Faces(newTopFace.FrontCube);
            newTopFace.FrontRightCube.AddCubeWith2Faces(newTopFace.RightCube);
            newLeftFace.CenterCube.AddCubeWith2Faces(newLeftFace.FrontCube);
            newRightFace.CenterCube.AddCubeWith2Faces(newRightFace.FrontCube);
            newBottomFace.FrontLeftCube.AddCubeWith2Faces(newBottomFace.LeftCube);
            newBottomFace.CenterCube.AddCubeWith2Faces(newBottomFace.FrontCube);
            newBottomFace.FrontRightCube.AddCubeWith2Faces(newBottomFace.RightCube);
        }
    }
}

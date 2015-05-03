namespace RubixCube.Model
{
    internal class RubixCubeTopFaceRotation
    {
        private readonly RubixCubeTopFace newTopFace;
        private readonly RubixCubeFrontFace oldFrontFace;
        private readonly RubixCubeFrontFace newFrontFace;
        private readonly RubixCubeLeftFace oldLeftFace;
        private readonly RubixCubeLeftFace newLeftFace;
        private readonly RubixCubeRightFace oldRightFace;
        private readonly RubixCubeRightFace newRightFace;
        private readonly RubixCubeBackFace oldBackFace;
        private readonly RubixCubeBackFace newBackFace;

        public RubixCubeTopFaceRotation(RubixCube cube, RubixCubeTopFace newTopFace)
        {
            this.newTopFace = newTopFace;
            oldFrontFace = cube.FrontFace;
            newFrontFace = oldFrontFace.Clone();
            oldLeftFace = cube.LeftFace;
            newLeftFace = oldLeftFace.Clone();
            oldRightFace = cube.RightFace;
            newRightFace = oldRightFace.Clone();
            oldBackFace = cube.BackFace;
            newBackFace = oldBackFace.Clone();
            UpdateFaces();
            RemoveOldCubes();
            AddNewCubes();
        }

        public RubixCubeFrontFace NewFrontFace
        {
            get { return newFrontFace; }
        }

        public RubixCubeLeftFace NewLeftFace
        {
            get { return newLeftFace; }
        }

        public RubixCubeRightFace NewRightFace
        {
            get { return newRightFace; }
        }

        public RubixCubeBackFace NewBackFace
        {
            get { return newBackFace; }
        }

        private void UpdateFaces()
        {
            newFrontFace.TopLeftCube = newTopFace.FrontLeftCube;
            newFrontFace.TopCube = newTopFace.FrontCube;
            newFrontFace.TopRightCube = newTopFace.FrontRightCube;
            newLeftFace.FrontTopCube = newTopFace.FrontLeftCube;
            newLeftFace.TopCube = newTopFace.LeftCube;
            newLeftFace.BackTopCube = newTopFace.BackLeftCube;
            newRightFace.FrontTopCube = newTopFace.FrontRightCube;
            newRightFace.TopCube = newTopFace.RightCube;
            newRightFace.BackTopCube = newTopFace.BackRightCube;
            newBackFace.TopLeftCube = newTopFace.BackLeftCube;
            newBackFace.TopCube = newTopFace.BackCube;
            newBackFace.TopRightCube = newTopFace.BackRightCube;
        }

        private void RemoveOldCubes()
        {
            oldFrontFace.TopLeftCube.RemoveCubeWith2Faces(oldFrontFace.LeftCube);
            oldFrontFace.CenterCube.RemoveCubeWith2Faces(oldFrontFace.TopCube);
            oldFrontFace.TopRightCube.RemoveCubeWith2Faces(oldFrontFace.RightCube);
            oldLeftFace.CenterCube.RemoveCubeWith2Faces(oldLeftFace.TopCube);
            oldRightFace.CenterCube.RemoveCubeWith2Faces(oldRightFace.TopCube);
            oldBackFace.TopLeftCube.RemoveCubeWith2Faces(oldBackFace.LeftCube);
            oldBackFace.CenterCube.RemoveCubeWith2Faces(oldBackFace.TopCube);
            oldBackFace.TopRightCube.RemoveCubeWith2Faces(oldBackFace.RightCube);
        }

        private void AddNewCubes()
        {
            newFrontFace.TopLeftCube.AddCubeWith2Faces(newFrontFace.LeftCube);
            newFrontFace.CenterCube.AddCubeWith2Faces(newFrontFace.TopCube);
            newFrontFace.TopRightCube.AddCubeWith2Faces(newFrontFace.RightCube);
            newLeftFace.CenterCube.AddCubeWith2Faces(newLeftFace.TopCube);
            newRightFace.CenterCube.AddCubeWith2Faces(newRightFace.TopCube);
            newBackFace.TopLeftCube.AddCubeWith2Faces(newBackFace.LeftCube);
            newBackFace.CenterCube.AddCubeWith2Faces(newBackFace.TopCube);
            newBackFace.TopRightCube.AddCubeWith2Faces(newBackFace.RightCube);
        }
    }
}
